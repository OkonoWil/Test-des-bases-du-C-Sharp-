using System;
using System.Collections;//On importe la bibiothéque System.Collections pour util

namespace SanteCamerounConsole
{
	public class Patient
	{
		//Déclaration des attributs : par convention le nom des attributs commence toujours par un underscore ( _ )
		private string _nomPatient;
		private string _idPatient;
		private ArrayList _tabConsultation;

		//Déclaration de la variable de class
		private static int autoID = 1;

		//Déclaration et défintion  de la propriété
		public string NomPatient
        {
			get => _nomPatient;
			set => _nomPatient = value;
        }

		//Constructeur
		public Patient(string nomPartien)
		{
			this._nomPatient = nomPartien;
			this._idPatient = $"PAT{autoID}";
			this._tabConsultation = new ArrayList();
			autoID++;//autoID sera incrémenté à chaque création d'une instance de la class Patient
		}

		//Méthode addConsutation
		public void addConsultation(Consultation c)
        {
			if (!this._tabConsultation.Contains(c))//On teste si la collection ne contient pas la consultation C
				this._tabConsultation.Add(c);//Si la condiction est vérifié on ajout c à _tabConsultation
        }

		//Méthode compteMedicament
		public int compteMedicament(Medicament medoc)
        {
			int compteur = 0;//Initialisation du compteur
			foreach(Consultation c in this._tabConsultation)//===Pour chaque consultation de _tabConsultation faire ( on utilise la boucle foreach pour parcourir la collection)
            {
				foreach (Medicament m in c.TabMedicament)//===Pour chaque medicament de _tabMedicament faire
					if (medoc.IdMedicament == m.IdMedicament)//On teste si l'id des deux médicaments sont identique 
						compteur++;//si la condition est vérifié on incrémente le compteur
            }
			return compteur;//on retourne la valeur final du compteur
        }

		//Méthode d'affichage
		public void afficher()
        {
			Console.WriteLine($"\nId du patient : {this._idPatient} \t Nom du patient : {this._nomPatient} \nListe des consultation :");
			foreach (Consultation c in this._tabConsultation)//===Pour chaque consultation de _tabConsultation faire
				c.afficher();//on affiche la consultation c
			Console.WriteLine();//mise en forme ( juste pour la présentation du terminal )
        }
	}

}
