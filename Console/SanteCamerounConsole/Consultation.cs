using System;
using System.Collections;

namespace SanteCamerounConsole
{
	public class Consultation
	{
		private string _nomMedecin;
		private DateTime _date;
		private string _idConsultation;
		private ArrayList _tabMedicament;

		private static int autoID = 1;

		public ArrayList TabMedicament
        {
			get => _tabMedicament;
			set => _tabMedicament = value;
        }
		public Consultation(string nomMedecin)
		{
			this._nomMedecin = nomMedecin;
			this._date = DateTime.Now;
			this._idConsultation = $"MED{autoID}";
			this._tabMedicament = new ArrayList();
			autoID++;
		}

		public void addMedicament(Medicament m)
        {
			this._tabMedicament.Add(m);
        }

		public void afficher()
        {
			Console.WriteLine($"\t - Id de la consultation : {this._idConsultation} \t Nom du médecin : {this._nomMedecin}" +
				$" \t Date : {this._date} \n\t   Liste des médicaments prescrit :");
			foreach(Medicament m in this._tabMedicament)
            {
				Console.WriteLine($"\t\t * {m}");
            }
        }
	}

}