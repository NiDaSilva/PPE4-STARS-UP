import android.os.Bundle;

import com.example.ppe.starsup.Modele;
import com.example.ppe.starsup.R;

/**
 * Created by bouhours on 11/03/2016.
 */
public class MainActivity {
    private Modele maBDO;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
/*creation de la nouvelle BDO*/
        maBDO = new Modele();

}
