using System;

namespace SanteCamerounConsole
{
	public class Medicament
	{
		//Déclaration des attributs : par convention le nom des attributs commence toujours par un underscore ( _ )
		private string _nomMedicament;
		private string _idMedicament;

		//Déclaration de la variable de class
		private static int autoID = 1;

		//Déclaration et défintion  de la propriété
		public string NomMedicament
        {
			get => _nomMedicament;//Getter
			set => _idMedicament = value;//Setter
        }

		//Déclaration et défintion  de la propriété
		public string IdMedicament
        {
            get//Getter
            {
				return _idMedicament;
            }
            set//Setter
            {
				this._idMedicament = value;
            }
        }

		//Constructeur
		public Medicament(string nom)
        {
			this._nomMedicament = nom;
			this._idMedicament = $"MED{autoID}";
			autoID++;//autoID sera incrémenté à chaque création d'une instance de la class Patient
		}

		//On redéfini la Méthode ToString()
		public override string ToString() => $"Nom du médicament : {this._nomMedicament}  \t Id du médicament : {this._idMedicament}";
    }

}
