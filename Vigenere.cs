using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Vigenere{    //das hier ist analyse

    public string geheimtext;

    public string AufGutGlückAllesAufEinmal(string geheimtext){
        return Entschlüssel(geheimtext, KnackePasswort(KasiskiTest()));
    }
    public string KnackePasswort(int länge, char häufigsterBuchstabeDerSprache = 'e'){
        int passwortlänge = länge;  
        string geknacktesPasswort = "";
        for (int i = 0; i < passwortlänge; i++)
        {
            geknacktesPasswort += Passwortbuchstabe(passwortlänge, i, häufigsterBuchstabeDerSprache);
        }
        return geknacktesPasswort;
    }

    public int KasiskiTest(){                       //kann später einfach mit KasiskiTestArray arbeiten
        int meisteÜbereinstimmung = 0;
        string[] verschiebungen = ErstelleVerschiebungen(geheimtext.Length);
        for (int i = 1; i < geheimtext.Length; i++)
        {
            int a = AnzahlÜbereinstimmungen(verschiebungen[0], verschiebungen[i]);

            if (a > meisteÜbereinstimmung)
            {
                meisteÜbereinstimmung = i;
            }
        }
        return meisteÜbereinstimmung;
    }

    public int[] KasiskiArray(){
        int[] Übereinstimmungen = new int[geheimtext.Length];
        string[] verschiebungen = ErstelleVerschiebungen(geheimtext.Length);
        for (int i = 1; i < geheimtext.Length; i++)
        {
            Übereinstimmungen[i] = AnzahlÜbereinstimmungen(verschiebungen[0], verschiebungen[i]);
        }
        return Übereinstimmungen;
    }

    private string[] ErstelleVerschiebungen(int anzahl){ 
        
        string[] verschiebungen = new string[anzahl];
        for (int i = 0; i < verschiebungen.Length; i++)
        {
            verschiebungen[i] = VerschiebeGeheimtext(i);
        }
        return verschiebungen;
    }
    private int AnzahlÜbereinstimmungen(string erste, string zweite){ 
        int anzahl = 0;
        for (int i = 0; i < erste.Length; i++)
        {
            if (erste[i] == zweite[i])
                anzahl++;
        }
        return anzahl;
    }
    private string VerschiebeGeheimtext(int anzahl){ 
        string verschoben = "";
        for (int i = anzahl; i < geheimtext.Length + anzahl; i++)
        {
            verschoben += geheimtext[i % geheimtext.Length];
        }
        return verschoben;
    }
    public char Passwortbuchstabe(int passwortlänge, int stelleImPasswort, char häufigsterBuchstabeDerSprache = 'e'){  //man beachte stelle im Passwort fängt bei 0 an 
        int[,] häufigkeiten = Häufigkeitstabelle(passwortlänge);

        int häufigsterBuchstabe = 0;
        int anzahlHäufigsterB = 0;
        for (int i = 0; i < 26; i++)
        {
            if (häufigkeiten[stelleImPasswort,i] > anzahlHäufigsterB)
            {
                häufigsterBuchstabe = i;
                anzahlHäufigsterB = häufigkeiten[stelleImPasswort,i];
            }
        }
        return BuchstabeEntschlüsseln(alphabet[häufigsterBuchstabe], häufigsterBuchstabeDerSprache);
    }
    private int[,] Häufigkeitstabelle(int passwortlänge){
        int[,] häufigkeiten = new int[passwortlänge, 26];

        for (int stelle = 0; stelle < passwortlänge; stelle++)
        {
            for (int i = stelle; i < geheimtext.Length; i += passwortlänge)
            {
                häufigkeiten[stelle,StelleDesBuchstaben(geheimtext[i])] = häufigkeiten[stelle,StelleDesBuchstaben(geheimtext[i])] + 1 ;
            }
        }
        return häufigkeiten;
    }
}
