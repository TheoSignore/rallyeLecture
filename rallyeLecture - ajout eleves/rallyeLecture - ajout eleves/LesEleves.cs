using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture___ajout_eleves {
    class LesEleves {
        static public void CreateCsvPasswordFile(string niveau, int annee, List<Eleve> lesEleves) {
            string nomFichier = String.Format("../../../../{0}-{1}.txt",annee,niveau);
            StreamWriter fichier = new StreamWriter(nomFichier,false, System.Text.Encoding.GetEncoding(1252));
            foreach (Eleve elv in lesEleves) {
                string info = String.Format("{0}\t{1}\t{2}\t{3}",elv.Nom,elv.Prenom,elv.Login,elv.PassWord);
                fichier.WriteLine(info);
            }
            fichier.Close();

        }

        static public List<Eleve> LoadCsv(PassWordType passWordType,string csv) {
            StreamReader sr = new StreamReader(csv, System.Text.Encoding.GetEncoding(1252),false);
            List<Eleve> lesEleves = new List<Eleve>(); 
            while (!sr.EndOfStream) {
                string laLigne = sr.ReadLine();
                string decomposed = laLigne.Normalize(NormalizationForm.FormD);
                char[] filtered = decomposed.Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark).ToArray();
                string newString = new String(filtered);
                laLigne = newString;
                string[] info;
                if (laLigne.Contains(";")) info = laLigne.Split(';');
                else info = laLigne.Split('\t');
                string prenom = info[0];
                string nom = info[1];
                string login = fuckAccentAndSpaces(prenom) + fuckAccentAndSpaces(nom) + "@sio.jjr.fr";
                login = login.ToLower();
                Eleve unEleve = new Eleve(nom, prenom, login,passWordType);
                lesEleves.Add(unEleve);
            }
            return lesEleves;
        }
        static private string fuckAccentAndSpaces(string laChaine) {
            laChaine = laChaine.Replace('é', 'e');
            laChaine = laChaine.Replace('à', 'a');
            laChaine = laChaine.Replace('è', 'e');
            laChaine = laChaine.Replace(" ", "");
            return laChaine;
        }
    }
}
