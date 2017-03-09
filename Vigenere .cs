using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vigenere{
   
    public string passwort;

    private char[,] tabelle;

    private string alphabet = "abcdefghijklmnopqrstuvwxyz" ;//ich hatte erst char Array , string ist einfacher zu handhaben man könnte jede 26 durch alphabet.Length erstetzen sodass man auch andere buchstaben reinnehmen kann

    public Vigenere(string passwort = "",string geheimtext = ""){
        this.passwort = passwort;
        this.geheimtext = geheimtext;
        TabelleBelegen();
    }
    private void TabelleBelegen(){
        tabelle = new char[26, 26];
        for (int a = 0; a < 26; a++)
        {
            for (int b = 0; b < 26; b++)
            {
                tabelle[a, b] = alphabet[(a + b) % 26];
            }
        }
    }
    public string Verschlüssel(string klartext){
        string geheimtext = "";
        for (int i = 0; i < klartext.Length; i++)
        {
            geheimtext += BuchstabeVerschlüsseln(klartext[i],passwort[i%passwort.Length]);
        }
        return geheimtext;
    }
    private char BuchstabeVerschlüsseln (char klartextB, char passwortB){
        return tabelle[StelleDesBuchstaben(klartextB), StelleDesBuchstaben(passwortB)];
    }

    public string Entschlüssel(string geheimtext){
        string klartext = "";
        for (int i = 0; i < geheimtext.Length; i++)
        {
            klartext += BuchstabeEntschlüsseln(geheimtext[i],passwort[i%passwort.Length]);
        }
        return klartext;
    }

    public string Entschlüssel(string geheimtext, string vorübergehendesPasswort){
        string cachePasswort = this.passwort;
        this.passwort = vorübergehendesPasswort;
        string klartext = Entschlüssel(geheimtext);
        this.passwort = cachePasswort;
        return klartext;
    }

    private char BuchstabeEntschlüsseln(char geheimtextB,char andererB){ 
        for (int b = 0; b < 26; b++)
        {
            if (tabelle[StelleDesBuchstaben(andererB), b] == geheimtextB)
                return alphabet[b];
        }
        return geheimtextB;

    }
    private int StelleDesBuchstaben(char buchstabe){
        for (int i = 0; i < alphabet.Length; i++)
        {
            if (buchstabe == alphabet[i])
                return i;
        }
        return 0;
    }
}
