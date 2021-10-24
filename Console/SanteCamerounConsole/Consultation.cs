using System;
using System.Collections;

namespace SanteCamerounConsole
{
	public class Consultation
	{
		//Déclaration des attributs : par convention le nom des attributs commence toujours par un underscore ( _ )
		private string _nomMedecin;
		private DateTime _date;
		private string _idConsultation;
		private ArrayList _tabMedicament;

		//Déclaration de la variable de class
		private static int autoID = 1;

		//Déclaration et défintion  de la propriété
		public ArrayList TabMedicament
        {
			get => _tabMedicament;//Getter
			set => _tabMedicament = value;//Setter
        }

		//Constructeur
		public Consultation(string nomMedecin)
		{
			this._nomMedecin = nomMedecin;
			this._date = DateTime.Now;
			this._idConsultation = $"CONSULT{autoID}";
			this._tabMedicament = new ArrayList();
			autoID++;
		}

		//Méthode addMedicament
		public void addMedicament(Medicament m)
        {
			this._tabMedicament.Add(m);
        }

		//Méthode d'affichage
		public void afficher()
        {
			Console.WriteLine($"\t - Id de la consultation : {this._idConsultation} \t Nom du médecin : {this._nomMedecin}" +
				$" \t Date : {this._date} \n\t   Liste des médicaments prescrit :");
			foreach(Medicament m in this._tabMedicament)//===Pour chaque Médicament de _tabMedicament faire
			{
				Console.WriteLine($"\t\t * {m}");//<=> Console.WriteLine($"\t\t * {m.ToString()}")    : on affiche le médicament
            }
        }
	}

}