using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//----------HATTEN-KADAI----------
//Boss-class_wo_sakusei
public class Boss{
    private int mp = 53;   //Hensuu-mp_wo_53_de_syokika 

    //Magic-kansuu_wo_sakusei
    public void Magic(){

        //mp >= 5_no_baai
        if(this.mp >= 5){
            this.mp -= 5;   //mp_wo_5syouhi
            Debug.Log("Mahou-kougeki_wo_sita. Nokori-MP_ha" + this.mp);

        //mp < 5_no_baai
		}else{
            Debug.Log("MP_ga_tarinai_tame_mahou_ga_tukaenai.");
		}
	}
}

public class Test : MonoBehaviour{

    void Start(){
        //----------KADAI_1----------
        //Yousosuu5_no_hairetu-array_wo_syokika
        int[] array = { 1, 3, 5, 7, 9 };

        //----------KADAI_2----------
        //Kakuyouso_no_atai_wo_junban_ni_hyouji
        for(int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);
		}
        
        //----------KADAI_3----------
        //Kakuyouso_no_atai_wo_gyakujun_ni_hyouji
        for(int i = array.Length - 1; i >= 0; i--){
            Debug.Log(array[i]);
		}

        //----------HATTEN-KADAI----------
        //Boss-class_no_hensuu_wo_sengensite_insutansu_wo_dainyuu
        Boss lastboss = new Boss();

        //Majic-kansuu_wo_11kai_yobidasu
        for(int j = 1; j <= 11; j++){
            lastboss.Magic();
		}
    }

    // Update is called once per frame
    void Update(){
        
    }
}
