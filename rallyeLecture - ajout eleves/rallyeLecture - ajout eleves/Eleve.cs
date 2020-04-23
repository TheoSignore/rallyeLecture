using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rallyeLecture___ajout_eleves {
    class Eleve {
        private string nom;
        private string prenom;
        private string login;
        private string passWord;
        private static readonly Random rand = new Random();


        public Eleve(string nom, string prenom, string login, PassWordType pst) {
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.passWord = GetNewPassWord(pst);
        }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Login { get => login; set => login = value; }
        public string PassWord { get => passWord; set => passWord = value; }

        private string GetPasswordAleatoire() {
            int chiffre = rand.Next(0, 10);
            char[] chiffres = { '0','1','2','3','4','5','6','7','8','9'};
            char plus = '+';
            char a = '@';
            char hashtag = '#';
            char dollar = '$';
            char esperluette = '&';
            char[] specialCha = { esperluette,hashtag, a, dollar, '£', '%', '*', 'µ', '§', '!',':','/','.',';','?',',','<','>','~','{','(','[','-','|','_','\\','^',')',']','}',plus,'='};
            char[] alphabet = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] motDePass = new char[9];
            char[] compose = new char[9];
            compose[0] = Convert.ToChar(Convert.ToString(alphabet[rand.Next(0, 26)]).ToUpper());
            compose[1] = chiffres[chiffre];
            compose[2] = specialCha[rand.Next(0,31)];
            for (int i = 3;  i < compose.Length; i++) {
                compose[i] = alphabet[rand.Next(0,26)];
            }
            List<Int32> positions = new List<Int32>();
            for (int i = 0; i < motDePass.Length; i++) {
                bool goodPos = false;
                int pos = 0;
                while (!goodPos) {
                    goodPos = true;
                    pos = rand.Next(0, 9);
                    foreach (int integeur in positions) {
                        if (integeur == pos) goodPos = false;
                    }
                }
                positions.Add(pos);
                motDePass[i] = compose[pos]; 
            }
            string wpa = "";
            foreach (char ch in motDePass) {
                wpa += ch;
            }
            return wpa;
        }

        private string GetPassWordConstruit() {
            string passConstruit = this.prenom[0] + this.nom;
            passConstruit = passConstruit.Replace(" ", "");
            return passConstruit.ToLower();
        }
        public string GetNewPassWord(PassWordType passWordType) {
            if (PassWordType.aleatoire == passWordType) return GetPasswordAleatoire();
            else return GetPassWordConstruit();
        }
    }
}
