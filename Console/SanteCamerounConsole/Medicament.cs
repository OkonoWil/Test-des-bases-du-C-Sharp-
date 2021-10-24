using System;

namespace SanteCamerounConsole
{
	public class Medicament
	{
		//Attribut
		private string _nomMedicament;
		private string _idMedicament;

		private static int autoID = 1;

		public string NomMedicament
        {
			get => _nomMedicament;
			set => _idMedicament = value;
        }

		public string IdMedicament
        {
            get
            {
				return _idMedicament;
            }
            set
            {
				this._idMedicament = value;
            }
        }

		public Medicament(string nom)
        {
			this._nomMedicament = nom;
			this._idMedicament = $"MED{autoID}";
			autoID++;
        }

		public override string ToString() => $"Nom du médicament : {this._nomMedicament}  \t Id du médicament : {this._idMedicament}";
    }

}
