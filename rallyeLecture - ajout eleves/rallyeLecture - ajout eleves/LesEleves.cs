using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture___ajout_eleves {
    class LesEleves {

        static public void CreateCsvPasswordFile() {

        }

        static public List<Eleve> LoadCsv(PassWordType passWordType,string csv) {
            StreamReader sr = new StreamReader(csv);
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
                string login = prenom + nom + "@sio.jjr.fr";
                login = login.ToLower();
                Eleve unEleve = new Eleve(nom, prenom, login,passWordType);
                lesEleves.Add(unEleve);
            }
            return lesEleves;
        }
    }
}
