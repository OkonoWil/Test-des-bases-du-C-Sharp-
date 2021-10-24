using System;
using System.Collections;

namespace SanteCamerounConsole
{
	public class Patient
	{
		private string _nomPatient;
		private string _idPatient;
		private ArrayList _tabConsultation;

		private static int autoID = 1;

		public string NomPatient
        {
			get => _nomPatient;
			set => _nomPatient = value;
        }

		public Patient(string nomPartien)
		{
			this._nomPatient = nomPartien;
			this._idPatient = $"MED{autoID}";
			this._tabConsultation = new ArrayList();
			autoID++;
		}

		public void addConsultation(Consultation c)
        {
			if (!this._tabConsultation.Contains(c))
				this._tabConsultation.Add(c);
        }

		public int compteMedicament(Medicament medoc)
        {
			int compteur = 0;
			foreach(Consultation c in this._tabConsultation)
            {
				foreach (Medicament m in c.TabMedicament)
					if (medoc.IdMedicament == m.IdMedicament)
						compteur++;
            }
			return compteur;
        }

		public void afficher()
        {
			Console.WriteLine($"\nId du patient : {this._idPatient} \t Nom du patient : {this._nomPatient} \nListe des consultation :");
			foreach (Consultation c in this._tabConsultation)
				c.afficher();
			Console.WriteLine();
        }
	}

}
