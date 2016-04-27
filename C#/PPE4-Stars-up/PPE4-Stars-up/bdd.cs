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
        string test, log;

        private MySqlConnection myConnection;
        private bool connopen = false;
        private bool errgrave = false;
        private bool chargement = false;

        private bool errmaj = false;
        private char vaction, vtable;
        private ArrayList rapport = new ArrayList(); // pour gérer le rapport des erreurs de maj

        private MySqlDataAdapter mySqlDataAdapterTP7 = new MySqlDataAdapter();
        private DataSet dataSetTP7 = new DataSet();
        private DataView dv_login, dv_visite, dv_specialite, dv_NbEtoiles, dv_Historique, dv_Historique_Dep, dv_Historique_Etoile, dv_maj_etoile_commentaire, dv_inspecteur, dv_nb_visite_total, dv_nb_visite_passee, dv_nb_visite_today, dv_nb_visite_passee_non_evaluee, dv_nb_visite_prevue, dv_pdp, dv_departement, dv_temps_con, dv_all_temps_con, dv_maj_tps_con, dv_id_inspe = new DataView();

        #region Lecture du fichier
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

                if (counter == 9)
                {

                    log = line.ToString();
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

        public string recupLogin()
        {
            // Id de l'inspecteur connecté

            lireFichier();
            return log;
        }
        #endregion

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

        public DataView Dv_NbEtoiles
        {
            get { return dv_NbEtoiles; }
            set { dv_NbEtoiles = value; }
        }

        public DataView Dv_Historique
        {
            get { return dv_Historique; }
            set { dv_Historique = value; }
        }

        public DataView Dv_Historique_Etoile
        {
            get { return dv_Historique_Etoile; }
            set { dv_Historique_Etoile = value; }
        }

        public DataView Dv_Historique_Dep
        {
            get { return dv_Historique_Dep; }
            set { dv_Historique_Dep = value; }
        }

        public DataView Dv_maj_etoile_commentaire
        {
            get
            {
                return dv_maj_etoile_commentaire;
            }

            set
            {
                dv_maj_etoile_commentaire = value;
            }
        }

        public DataView Dv_inspecteur
        {
            get
            {
                return dv_inspecteur;
            }

            set
            {
                dv_inspecteur = value;
            }
        }

        public DataView Dv_nb_visite_total
        {
            get
            {
                return dv_nb_visite_total;
            }

            set
            {
                dv_nb_visite_total = value;
            }
        }

        public DataView Dv_nb_visite_passee
        {
            get
            {
                return dv_nb_visite_passee;
            }

            set
            {
                dv_nb_visite_passee = value;
            }
        }

        public DataView Dv_nb_visite_today
        {
            get
            {
                return dv_nb_visite_today;
            }

            set
            {
                dv_nb_visite_today = value;
            }
        }

        public DataView Dv_nb_visite_passee_non_evaluee
        {
            get
            {
                return dv_nb_visite_passee_non_evaluee;
            }

            set
            {
                dv_nb_visite_passee_non_evaluee = value;
            }
        }

        public DataView Dv_nb_visite_prevue
        {
            get
            {
                return dv_nb_visite_prevue;
            }

            set
            {
                dv_nb_visite_prevue = value;
            }
        }

        public DataView Dv_pdp
        {
            get
            {
                return dv_pdp;
            }

            set
            {
                dv_pdp = value;
            }
        }

        public DataView Dv_departement
        {
            get
            {
                return dv_departement;
            }

            set
            {
                dv_departement = value;
            }
        }

        public DataView Dv_temps_con
        {
            get
            {
                return dv_temps_con;
            }

            set
            {
                dv_temps_con = value;
            }
        }

        public DataView Dv_all_temps_con
        {
            get
            {
                return dv_all_temps_con;
            }

            set
            {
                dv_all_temps_con = value;
            }
        }

        public DataView Dv_maj_tps_con
        {
            get
            {
                return dv_maj_tps_con;
            }

            set
            {
                dv_maj_tps_con = value;
            }
        }

        public DataView Dv_id_inspe
        {
            get
            {
                return dv_id_inspe;
            }

            set
            {
                dv_id_inspe = value;
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
            string myConnectionString = "Database=ppe4;Data Source=192.168.215.10;User Id=root; "; // SERVEUR
            // string myConnectionString = "Database=ppe4;Data Source=localhost;User Id=root; "; // LOCAL

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
            mySqlDataAdapterTP7.SelectCommand = new MySqlCommand("select * from inspecteur; select v.ID_HEBERGEMENT as 'ID', h.NOM_HEBERGEMENT as 'NOM', h.ADRESSE_HEBERGEMENT as 'ADRESSE', h.VILLE_HEBERGEMENT as 'VILLE', v.DATE_HEURE_VISITE as 'DATE', h.HORAIRES, v.COMMENTAIRE_VISITE from visite as v inner join hebergement as h on v.ID_HEBERGEMENT = h.ID_HEBERGEMENT where id_inspecteur =" + recup() + "; SELECT Libelle_specialite FROM specialite as s INNER JOIN inspecteur as i on s.ID_SPECIALITE = i.ID_SPECIALITE where id_inspecteur =" + recup() + "; Select ID_HEBERGEMENT as 'ID', DATE_HEURE_VISITE as 'Date_Heure', NOMBRE_ETOILE_VISITE as 'Nb Etoiles' FROM visite ORDER BY Date_Heure DESC; SELECT v.DATE_HEURE_VISITE as 'Date & Heure', d.LIBELLE_DEPARTEMENT as 'Departement', h.NOM_HEBERGEMENT as 'Hebergement', v.NOMBRE_ETOILE_VISITE as 'Etoile', v.COMMENTAIRE_VISITE as 'Commentaire' FROM departement as d INNER JOIN hebergement as h on d.ID_DEPARTEMENT = h.ID_DEPARTEMENT INNER JOIN visite as v on h.ID_HEBERGEMENT = v.ID_HEBERGEMENT WHERE v.ID_INSPECTEUR =" + recup() + " AND v.DATE_HEURE_VISITE < DATE(NOW()) ORDER BY DATE_HEURE_VISITE ASC; SELECT v.DATE_HEURE_VISITE as 'Date & Heure', d.LIBELLE_DEPARTEMENT as 'Departement', h.NOM_HEBERGEMENT as 'Hebergement', v.NOMBRE_ETOILE_VISITE as 'Etoile', v.COMMENTAIRE_VISITE as 'Commentaire' FROM departement as d INNER JOIN hebergement as h on d.ID_DEPARTEMENT = h.ID_DEPARTEMENT INNER JOIN visite as v on h.ID_HEBERGEMENT = v.ID_HEBERGEMENT WHERE v.ID_INSPECTEUR =" + recup() + " AND v.DATE_HEURE_VISITE < DATE(NOW()) ORDER BY Departement ASC; SELECT v.DATE_HEURE_VISITE as 'Date & Heure', d.LIBELLE_DEPARTEMENT as 'Departement', h.NOM_HEBERGEMENT as 'Hebergement', v.NOMBRE_ETOILE_VISITE as 'Etoile', v.COMMENTAIRE_VISITE as 'Commentaire' FROM departement as d INNER JOIN hebergement as h on d.ID_DEPARTEMENT = h.ID_DEPARTEMENT INNER JOIN visite as v on h.ID_HEBERGEMENT = v.ID_HEBERGEMENT WHERE v.ID_INSPECTEUR =" + recup() + " AND v.DATE_HEURE_VISITE < DATE(NOW()) ORDER BY Etoile ASC; SELECT ID_INSPECTEUR, ID_HEBERGEMENT, COMMENTAIRE_VISITE, NOMBRE_ETOILE_VISITE FROM visite; SELECT CONCAT(PERNOM_INSPECTEUR, ' ', NOM_INSPECTEUR) FROM inspecteur WHERE ID_INSPECTEUR =" + recup() + "; SELECT count(ID_INSPECTEUR) FROM visite WHERE ID_INSPECTEUR =" + recup() + "; Select count(ID_INSPECTEUR) FROM visite WHERE DATE_HEURE_VISITE < DATE(NOW()) AND ID_INSPECTEUR =" + recup() + "; Select count(ID_INSPECTEUR) FROM visite WHERE DAY(DATE_HEURE_VISITE) = DAY(DATE(NOW())) AND MONTH(DATE_HEURE_VISITE) = MONTH(DATE(NOW())) AND YEAR(DATE_HEURE_VISITE) = YEAR(DATE(NOW())) AND ID_INSPECTEUR =" + recup() + "; Select count(ID_INSPECTEUR) FROM visite WHERE DATE_HEURE_VISITE < DATE(NOW()) AND COMMENTAIRE_VISITE IS NULL AND ID_INSPECTEUR =" + recup() + "; Select count(ID_INSPECTEUR) FROM visite WHERE DAY(DATE_HEURE_VISITE) > DAY(DATE(NOW())) AND MONTH(DATE_HEURE_VISITE) >= MONTH(DATE(NOW())) AND YEAR(DATE_HEURE_VISITE) >= YEAR(DATE(NOW())) AND ID_INSPECTEUR =" + recup() + "; SELECT * FROM inspecteur WHERE ID_INSPECTEUR =" + recup() + "; SELECT libelle_departement FROM inspecteur as i INNER JOIN departement as d on i.ID_DEPARTEMENT = d.ID_DEPARTEMENT WHERE ID_INSPECTEUR =" + recup() + "; SELECT ID_CONNEXION, ID_INSPECTEUR, DEBUT_CONNEXION, FIN_CONNEXION FROM temps_connexion where ID_INSPECTEUR =" + recup() + "; SELECT ID_CONNEXION, ID_INSPECTEUR, DEBUT_CONNEXION, FIN_CONNEXION FROM temps_connexion; select ID_INSPECTEUR, TEMPS_CONNEXION from inspecteur; SELECT ID_INSPECTEUR FROM inspecteur WHERE LOGIN ='" + recupLogin() + "'; ", myConnection);   
            
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
                        dv_NbEtoiles = dataSetTP7.Tables[3].DefaultView; // Récupération du nombre d'étoiles de tous les hébergements
                        dv_Historique = dataSetTP7.Tables[4].DefaultView; // Récupération de l'historique de l'inspecteur trier par défaut (DATE)
                        dv_Historique_Dep = dataSetTP7.Tables[5].DefaultView; // Récupération de l'historique de l'inspecteur trier par Département
                        dv_Historique_Etoile = dataSetTP7.Tables[6].DefaultView; // Récupération de l'historique de l'inspecteur trier par Etoile
                        dv_maj_etoile_commentaire = dataSetTP7.Tables[7].DefaultView; // pour maj export
                        dv_inspecteur = dataSetTP7.Tables[8].DefaultView; // Récupération du nom et prénom de l'inspecteur concaténé
                        dv_nb_visite_total = dataSetTP7.Tables[9].DefaultView; // Nombre de visite total par inspecteur
                        dv_nb_visite_passee = dataSetTP7.Tables[10].DefaultView; // Nombre de visite passées par inspecteur
                        dv_nb_visite_today = dataSetTP7.Tables[11].DefaultView; // Nombre de visite prévue aujourd'hui par inspecteur
                        dv_nb_visite_passee_non_evaluee = dataSetTP7.Tables[12].DefaultView; // Nombre de visite passées non evaluées par inspecteur
                        dv_nb_visite_prevue = dataSetTP7.Tables[13].DefaultView; // Nombre de visite prévue par inspecteur
                        dv_pdp = dataSetTP7.Tables[14].DefaultView; // Photo de profil de l'inspecteur
                        dv_departement = dataSetTP7.Tables[15].DefaultView; // Récupère le departement de l'inspecteur
                        dv_temps_con = dataSetTP7.Tables[16].DefaultView; // Temps de connexion par inspecteur
                        dv_all_temps_con = dataSetTP7.Tables[17].DefaultView; // Tous les temps de connexion 
                        dv_maj_tps_con = dataSetTP7.Tables[18].DefaultView; // Tous les temps de connexion 
                        dv_id_inspe = dataSetTP7.Tables[19].DefaultView; // Récupération de l'id 

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
                    if (vtable == 'v') // ‘v’ pour table visite
                    {
                        vcommand.CommandText = "SELECT COUNT(*) FROM visite WHERE ID_INSPECTEUR = '" + args.Row[0, DataRowVersion.Original] + "'";
                    }

                    nb = (Int64)vcommand.ExecuteScalar();
                    // on veut savoir si la visite existe encore dans la base

                    MySqlCommand vcommand2 = myConnection.CreateCommand();
                    if (vtable == 't') // ‘t’ pour table temps_connexion
                    {
                        vcommand2.CommandText = "SELECT COUNT(*) FROM temps_connexion WHERE ID_INSPECTEUR = '" + args.Row[0, DataRowVersion.Original] + "'";
                    }

                    nb = (Int64)vcommand2.ExecuteScalar();

                    MySqlCommand vcommand3 = myConnection.CreateCommand();
                    if (vtable == 'i') // ‘i’ pour table inspecteur
                    {
                        vcommand3.CommandText = "SELECT COUNT(*) FROM inspecteur WHERE ID_INSPECTEUR = '" + args.Row[0, DataRowVersion.Original] + "'";
                    }

                    nb = (Int64)vcommand3.ExecuteScalar();

                }
                if (vaction == 'd')
                {
                    if (nb == 1) // pour delete si l'enr a été supprimé on n'affiche pas l'erreur
                    {
                        if (vtable == 'v')
                        {
                            msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Original] + " Impossible delete car enr modifié dans la base";
                        }

                        rapport.Add(msg);
                        errmaj = true;
                    }
                }
                if (vaction == 'u')
                {
                    if (nb == 1)
                    {
                        if (vtable == 'v')
                        {
                            msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr modifié dans la base";
                        }

                        rapport.Add(msg);
                        errmaj = true;
                    }
                    else
                    {
                        if (vtable == 'v')
                        {
                            msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr supprimé dans la base";
                        }

                        rapport.Add(msg);
                        errmaj = true;
                    }

                    //

                    if (nb == 1)
                    {
                        if (vtable == 't')
                        {
                            msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr modifié dans la base";
                        }

                        rapport.Add(msg);
                        errmaj = true;
                    }
                    else
                    {
                        if (vtable == 't')
                        {
                            msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr supprimé dans la base";
                        }

                        rapport.Add(msg);
                        errmaj = true;
                    }

                    //

                    if (nb == 1)
                    {
                        if (vtable == 'i')
                        {
                            msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr modifié dans la base";
                        }

                        rapport.Add(msg);
                        errmaj = true;
                    }
                    else
                    {
                        if (vtable == 'i')
                        {
                            msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Original] + " Impossible MAJ car enr supprimé dans la base";
                        }

                        rapport.Add(msg);
                        errmaj = true;
                    }
                }
                if (vaction == 'c')
                {
                    if (vtable == 'v')
                    {
                        msg = "Pour le numéro des visites : " + args.Row[0, DataRowVersion.Current] + " Impossible ADD car erreur données";
                    }

                    rapport.Add(msg);
                    errmaj = true;
                }
            }
        }

        // Ajout Inutile car pas d'ajout dans ce projet

        /*

        public void add_visite()
        {
            vaction = 'c'; // on précise bien l’action, ici c pour create
            vtable = 'v';

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

        */


        public void maj_visite()
        {
            
            vaction = 'u'; // on précise bien l’action, ici u pour update
            vtable = 'v';
            
            if (!connopen) return;
            //appel d'une méthode sur l'événement modifie d'un enr de la table
            mySqlDataAdapterTP7.RowUpdated += new MySqlRowUpdatedEventHandler(OnRowUpdated);
            mySqlDataAdapterTP7.UpdateCommand = new MySqlCommand("update visite set COMMENTAIRE_VISITE =?commentaire, NOMBRE_ETOILE_VISITE =?nb_etoile where ID_INSPECTEUR = ?id_inspecteur and ID_HEBERGEMENT = ?id_hebergement", myConnection);
            //déclaration des variables utiles au commandbuilder
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?id_inspecteur", MySqlDbType.Int16, 10, "ID_INSPECTEUR");
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?id_hebergement", MySqlDbType.Int16, 10, "ID_HEBERGEMENT");
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?commentaire", MySqlDbType.Text, 65535, "COMMENTAIRE_VISITE"); 
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?nb_etoile", MySqlDbType.Int16, 10, "NOMBRE_ETOILE_VISITE");  
            //on continue même si erreur de MAJ
            mySqlDataAdapterTP7.ContinueUpdateOnError = true;
            //table concernée 6 = visite
            DataTable table = dataSetTP7.Tables[7];
            //on ne s'occupe que des enregistrement ajoutés en local
            mySqlDataAdapterTP7.Update(table.Select(null, null, DataViewRowState.ModifiedCurrent)); 
            //désassocie la méthode sur l'événement maj de la base
            mySqlDataAdapterTP7.RowUpdated -= new MySqlRowUpdatedEventHandler(OnRowUpdated);
            
        }

        
        public void maj_temps_connexion()
        {
            vaction = 'u'; // on précise bien l’action, ici u pour update
            vtable = 't';

            // update temps_connexion set DEBUT_CONNEXION = "2016-04-15 22:22:22" where ID_INSPECTEUR = 4

            if (!connopen) return;
            //appel d'une méthode sur l'événement modifie d'un enr de la table
            mySqlDataAdapterTP7.RowUpdated += new MySqlRowUpdatedEventHandler(OnRowUpdated);
            mySqlDataAdapterTP7.UpdateCommand = new MySqlCommand("update temps_connexion set DEBUT_CONNEXION =?deb_con, FIN_CONNEXION =?fin_con where ID_INSPECTEUR = ?id_inspecteur", myConnection);
            //déclaration des variables utiles au commandbuilder
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?id_connexion", MySqlDbType.Int16, 10, "ID_CONNEXION");
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?id_inspecteur", MySqlDbType.Int16, 10, "ID_INSPECTEUR");
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?deb_con", MySqlDbType.DateTime, 19, "DEBUT_CONNEXION");
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?fin_con", MySqlDbType.DateTime, 19, "FIN_CONNEXION");
            //on continue même si erreur de MAJ
            mySqlDataAdapterTP7.ContinueUpdateOnError = true;
            //table concernée 16 = temps_connexion
            DataTable table = dataSetTP7.Tables[17];
            //on ne s'occupe que des enregistrement ajoutés en local
            mySqlDataAdapterTP7.Update(table.Select(null, null, DataViewRowState.ModifiedCurrent));
            //désassocie la méthode sur l'événement maj de la base
            mySqlDataAdapterTP7.RowUpdated -= new MySqlRowUpdatedEventHandler(OnRowUpdated);
        }

        public void maj_tps_co_ins()
        {
            vaction = 'u'; // on précise bien l’action, ici u pour update
            vtable = 'i';

            // update temps_connexion set DEBUT_CONNEXION = "2016-04-15 22:22:22" where ID_INSPECTEUR = 4

            if (!connopen) return;
            //appel d'une méthode sur l'événement modifie d'un enr de la table
            mySqlDataAdapterTP7.RowUpdated += new MySqlRowUpdatedEventHandler(OnRowUpdated);
            mySqlDataAdapterTP7.UpdateCommand = new MySqlCommand("update inspecteur set TEMPS_CONNEXION =?tps_co where ID_INSPECTEUR = ?id_inspecteur", myConnection);
            //déclaration des variables utiles au commandbuilder
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?id_inspecteur", MySqlDbType.Int16, 10, "ID_INSPECTEUR");
            mySqlDataAdapterTP7.UpdateCommand.Parameters.Add("?tps_co", MySqlDbType.Int64, 255, "TEMPS_CONNEXION");
            //on continue même si erreur de MAJ
            mySqlDataAdapterTP7.ContinueUpdateOnError = true;
            //table concernée 16 = temps_connexion
            DataTable table = dataSetTP7.Tables[18];
            //on ne s'occupe que des enregistrement ajoutés en local
            mySqlDataAdapterTP7.Update(table.Select(null, null, DataViewRowState.ModifiedCurrent));
            //désassocie la méthode sur l'événement maj de la base
            mySqlDataAdapterTP7.RowUpdated -= new MySqlRowUpdatedEventHandler(OnRowUpdated);
        }


        // Suppression Inutile car pas de suppression dans ce projet

        /*

        public void del_visite()
        {
            vaction = 'd'; // on précise bien l’action, ici c pour delete
            vtable = 'v';

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
        
    */

        public void export()
        {
            if (!connopen) return;
            
                try
                {
                    /*
                    try
                    {
                        add_visite();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur add : " + err, "Probleme ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errgrave = true;
                    }
                    */

                    try 
                    {
                         maj_visite();
                         maj_temps_connexion();
                         maj_tps_co_ins();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur dans la mise à jour de la base de données : " + err, "Probleme dans la mise à jour de la base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errgrave = true;
                    }

                    /*
                    try
                    {
                        del_visite();
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Erreur del: " + err, "Probleme suppr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errgrave = true;
                    }
                    */
                }
                catch (Exception err)
                {
                    MessageBox.Show("Erreur de chargement du dataset : " + err, "Probleme Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errgrave = true;
                }
            
        }

        #endregion
    }
}
