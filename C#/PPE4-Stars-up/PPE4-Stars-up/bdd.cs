using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace PPE4_Stars_up
{
    class bdd
    {
        int idI;
        string test;

        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool errgrave = false;
        private bool chargement = false;

        private bool errmaj = false;
        private char vaction, vtable;
        private ArrayList rapport = new ArrayList(); // pour gérer le rapport des erreurs de maj

        private MySqlDataAdapter mySqlDataAdapterTP7 = new MySqlDataAdapter();
        private DataSet dataSetTP7 = new DataSet();
        private DataView dv_login, dv_visite, dv_specialite = new DataView();

        private void lireFichier()
        {

            // string[] lines = System.IO.File.ReadAllLines(@"C:\PPE4_DR\Preferences_PPE4_DR.txt");

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\PPE4_DR\Preferences_PPE4_DR.txt");

            while ((line = file.ReadLine()) != null)
            {
                counter++;
                if (counter == 1)
                {

                    test = line.ToString();
                }
            }

            file.Close();

            // test = lines[0].ToString();
        }

        public int recup()
        {
            // Id de l'inspecteur connecté

            lireFichier();
            idI = Convert.ToInt32(test);
            return idI;
        }
       

        #region instanciation des variables

        public ArrayList Rapport
        {
            get { return rapport; }
            set { rapport = value; }
        }

        public DataView Dv_login
        {
            get { return dv_login; }
            set { dv_login = value; }
        }

        public bool Connopen
        {
            get { return connopen; }
            set { connopen = value; }
        }

        public bool Errgrave
        {
            get { return errgrave; }
            set { errgrave = value; }
        }

        public bool Chargement
        {
            get { return chargement; }
            set { chargement = value; }
        }

        public bool Errmaj
        {
            get{ return errmaj; }
            set{ errmaj = value; }
        }

        public char Vaction
        {
            get { return vaction; }
            set { vaction = value; }
        }

        public DataView Dv_visite
        {
            get
            {
                return dv_visite;
            }

            set
            {
                dv_visite = value;
            }
        }

        public DataView Dv_specialite
        {
            get
            {
                return dv_specialite;
            }

            set
            {
                dv_specialite = value;
            }
        }
        #endregion

        #region constructeur
        public bdd()
        {

        }
        #endregion

        #region seconnecter()
        public void seconnecter()
        {
            // string myConnectionString = "Database=ppe4;Data Source=192.168.215.10;User Id=root; "; // SERVEUR, ne fonctionne pas
            string myConnectionString = "Database=ppe4;Data Source=localhost;User Id=root; "; // localhost

            myConnection = new MySqlConnection(myConnectionString);
            try // tentative
            {
                myConnection.Open();
                connopen = true;
            }
            catch (Exception err)// gestion des erreurs
            {
                MessageBox.Show("Erreur ouverture bdd : " + err, "PBS connection", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                connopen = false; errgrave = true;
            }
        }
        #endregion

        #region sedeconnecter()
        public void sedeconnecter()
        {
            if (!connopen)
                return;
            try
            {
                myConnection.Close();
                myConnection.Dispose();
                connopen = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur fermeture bdd : " + err, "PBS deconnection", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                errgrave = true;
            }
        }
        #endregion

        #region méthode(s)
        public void import()
        {
            if (!connopen) return;
            mySqlDataAdapterTP7.SelectCommand = new MySqlCommand("select * from inspecteur; select * from visiter where id_inspecteur ="+ recup() + "; SELECT Libelle_specialite FROM specialite as s INNER JOIN inspecteur as i on s.ID_SPECIALITE = i.ID_SPECIALITE where id_inspecteur =" + recup() + "; ", myConnection);   
            
                try
                {
                        dataSetTP7.Clear();
                        mySqlDataAdapterTP7.Fill(dataSetTP7);
                        MySqlCommand vcommand = myConnection.CreateCommand();

                        // gestion des clés auto_increment : ici exemple sur la table personne : dataSetTP7.Tables[1]

                        /*
                        vcommand.CommandText = "SELECT AUTO_INCREMENT as last_id FROM INFORMATION_SCHEMA.TABLES WHERE table_name = 'inspecteur'";
                        UInt64 der_personne = (UInt64)vcommand.ExecuteScalar();
                        dataSetTP7.Tables[1].Columns[0].AutoIncrement = true;
                        dataSetTP7.Tables[1].Columns[0].AutoIncrementSeed = Convert.ToInt64(der_personne);
                        dataSetTP7.Tables[1].Columns[0].AutoIncrementStep = 1;
                        */

                        // remplissage des dataView à partir des tables du dataSet
                        dv_login = dataSetTP7.Tables[0].DefaultView; // Gestion de la connexion
                        dv_visite = dataSetTP7.Tables[1].DefaultView; // Gestion du remplissage du planning
                        dv_specialite = dataSetTP7.Tables[2].DefaultView; // Récupération de la spécialité

                        chargement = true;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur chargement dataset : " + err, "PBS inspecteur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errgrave = true;
                }
        }

        private void OnRowUpdated(object sender, MySqlRowUpdatedEventArgs args) // utile pour ajout,modif,supp
        {
            string msg = "";
            Int64 nb = 0;
            if (args.Status == UpdateStatus.ErrorsOccurred)
            {
                if (vaction == 'd' || vaction == 'u')
                {
                    MySqlCommand vcommand = myConnection.CreateCommand();
                    if (vtable == 'p') // ‘p’ pour table INSPECTEUR
                    {
                        vcommand.CommandText = "SELECT COUNT(*) FROM inspecteur WHERE Id_Inspecteur = '" + args.Row[0, DataRowVersion.Original] + "'";
                    }
                    nb = (Int64)vcommand.ExecuteScalar();
                    // on veut savoir si la personne existe encore dans la base
                }
                if (vaction == 'd')
                {
                    if (nb == 1) // pour delete si l'enr a été supprimé on n'affiche pas l'erreur
                    {
                        if (vtable == 'p')
                        {
                            msg = "Pour le numéro des inspecteurs : " + args.Row[0, DataRowVersion.Original] + " Impossible delete car enr modifié dans la base";
                        }
                        rapport.Add(msg);
                        errmaj = true;
                    }
                }
                if (vaction == 'u')
                {
                    if (nb == 1)
                    {
                        if (vtable == 'p')
                        {
                            msg = "Pour le numéro des inspecteurs : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr modifié dans la base";
                        }
                        rapport.Add(msg);
                        errmaj = true;
                    }
                    else
                    {
                        if (vtable == 'p')
                        {
                            msg = "Pour le numéro des inspecteurs : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr supprimé dans la base";
                        }
                        rapport.Add(msg);
                        errmaj = true;
                    }
                }
                if (vaction == 'c')
                {
                    if (vtable == 'p')
                    {
                        msg = "Pour le numéro des inspecteurs : " + args.Row[0, DataRowVersion.Current] + " Impossible ADD car erreur données";
                    }
                    rapport.Add(msg);
                    errmaj = true;
                }
            }
        }

        
        public void add_personne()
        {
            vaction = 'c'; // on précise bien l’action, ici c pour create
            vtable = 'p';

            if (!connopen) return;
            //appel d'une méthode sur l'événement ajout d'un enr de la table
            mySqlDataAdapterTP7.RowUpdated += new MySqlRowUpdatedEventHandler(OnRowUpdated);
            mySqlDataAdapterTP7.InsertCommand = new MySqlCommand("insert into personne (nom,prenom,Intitule) values (?nom,?prenom, ?Intitule)", myConnection);// notre commandbuilder ici ajout non fait si erreur de données
            //déclaration des variables utiles au commandbuilder
            // pas besoin de créer l’IdPersonne car en auto-increment
            mySqlDataAdapterTP7.InsertCommand.Parameters.Add("?nom", MySqlDbType.Text, 65535, "nom");
            mySqlDataAdapterTP7.InsertCommand.Parameters.Add("?prenom", MySqlDbType.Text, 65535, "prenom");
            mySqlDataAdapterTP7.InsertCommand.Parameters.Add("?Intitule", MySqlDbType.Text, 65535, "Intitule");
            //on continue même si erreur de MAJ
            mySqlDataAdapterTP7.ContinueUpdateOnError = true;
            //table concernée 1 = personne
            DataTable table = dataSetTP7.Tables[1];
            //on ne s'occupe que des enregistrement ajoutés en local
            mySqlDataAdapterTP7.Update(table.Select(null, null, DataViewRowState.Added));
            //désassocie la méthode sur l'événement maj de la base
            mySqlDataAdapterTP7.RowUpdated -= new MySqlRowUpdatedEventHandler(OnRowUpdated);
        }

        public void maj_personne()
        {
            vaction = 'u'; // on précise bien l’action, ici c pour update
            vtable = 'p';

            if (!connopen) return;
            //appel d'une méthode sur l'événement modifie d'un enr de la table
            mySqlDataAdapterTP7.RowUpdated += new MySqlRowUpdatedEventHandler(OnRowUpdated);
            mySqlDataAdapterTP7.UpdateCommand = new MySqlCommand("update personne set nom =?nom, prenom =?prenom, IdFormation =?IdFormation where IdPersonne = ?num", myConnection);
            //déclaration des variables utiles au commandbuilder
            // pas besoin de créer l’IdPersonne car en auto-increment
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?num", MySqlDbType.Int16, 10, "IdPersonne"); 
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?nom", MySqlDbType.Text, 65535, "nom"); 
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?prenom", MySqlDbType.Text, 65535, "prenom");  
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?IdFormation", MySqlDbType.Int16, 10, "IdFormation");
            //on continue même si erreur de MAJ
            mySqlDataAdapterTP7.ContinueUpdateOnError = true;
            //table concernée 1 = personne
            DataTable table = dataSetTP7.Tables[1];
            //on ne s'occupe que des enregistrement ajoutés en local
            mySqlDataAdapterTP7.Update(table.Select(null, null, DataViewRowState.ModifiedCurrent)); 
            //désassocie la méthode sur l'événement maj de la base
            mySqlDataAdapterTP7.RowUpdated -= new MySqlRowUpdatedEventHandler(OnRowUpdated);
        }

        public void del_personne()
        {
            vaction = 'd'; // on précise bien l’action, ici c pour delete
            vtable = 'p';

            if (!connopen) return;
            //appel d'une méthode sur l'événement supprimer d'un enr de la table
            mySqlDataAdapterTP7.RowUpdated += new MySqlRowUpdatedEventHandler(OnRowUpdated);
            mySqlDataAdapterTP7.DeleteCommand = new MySqlCommand("delete from personne where IdPersonne =?num; ", myConnection);// force le delete même si maj dans la base
            //déclaration des variables utiles au commandbuilder
            // pas besoin de créer l’IdPersonne car en auto-increment  
            mySqlDataAdapterTP7.DeleteCommand.Parameters.Add("?num", MySqlDbType.Int16, 10, "IdPersonne");
            mySqlDataAdapterTP7.DeleteCommand.Parameters.Add("?nom", MySqlDbType.Text, 65535, "nom");
            mySqlDataAdapterTP7.DeleteCommand.Parameters.Add("?prenom", MySqlDbType.Text, 65535, "prenom");
            mySqlDataAdapterTP7.DeleteCommand.Parameters.Add("?IdFormation", MySqlDbType.Int16, 10, "IdFormation");
            //on continue même si erreur de MAJ
            mySqlDataAdapterTP7.ContinueUpdateOnError = true;
            //table concernée 1 = personne
            DataTable table = dataSetTP7.Tables[1];
            //on ne s'occupe que des enregistrement ajoutés en local
            mySqlDataAdapterTP7.Update(table.Select(null, null, DataViewRowState.Deleted)); 
            //désassocie la méthode sur l'événement maj de la base
            mySqlDataAdapterTP7.RowUpdated -= new MySqlRowUpdatedEventHandler(OnRowUpdated);
        }
        

        public void export()
        {
            if (!connopen) return;
            
                try
                {
                    try
                    {
                        add_personne();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur add : " + err, "Probleme ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errgrave = true;
                    }
                    try 
                    {
                        maj_personne();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur maj : " + err, "Probleme maj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errgrave = true;
                    }
                    try
                    {
                        del_personne();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur del: " + err, "Probleme suppr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errgrave = true;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur chargement dataset : " + err, "Probleme Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errgrave = true;
                }
            
        }

        #endregion
    }
}
