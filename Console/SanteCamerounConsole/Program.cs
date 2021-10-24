using System;

namespace SanteCamerounConsole
{
    class Program
    {
        static void Main(string[] args)
        {
			//Modification du nom du terminal
            Console.Title = "Sante Cameroun";

			//Création de 2 instance de Patient
			Patient P1 = new Patient("Samson");
			Patient P2 = new Patient("Jessica");

			//Création de 4 instance de Consultation
			Consultation C1 = new Consultation("Dr Donfack");
			Consultation C2 = new Consultation("Dr Okono");
			Consultation C3 = new Consultation("Dr Okono");
			Consultation C4 = new Consultation("Dr Donfack");

			//Création de 9 instance de Medicament
			Medicament M1 = new Medicament("Doliprane");
			Medicament M2 = new Medicament("Paracetamol");
			Medicament M3 = new Medicament("Efferalgan");
			Medicament M4 = new Medicament("Aspirine");
			Medicament M5 = new Medicament("Ascabiol lotion");
			Medicament M6 = new Medicament("Antibiotique");
			Medicament M7 = new Medicament("Vitamine C");
			Medicament M8 = new Medicament("Chabiothé");
			Medicament M9 = new Medicament("Voelkel");

			//Utilisation de la méthode addConsultation de la class Patient
			P1.addConsultation(C1);
			P1.addConsultation(C1);//On ajout à nouveau la consultation C1 pour tester la contrainte
			P1.addConsultation(C2);
			P2.addConsultation(C3);
			P2.addConsultation(C3);//On ajout à nouveau la consultation C3 pour tester la contrainte
			P2.addConsultation(C4);

			//Utilisation de la méthode addMedicament de la class Consultation
			C1.addMedicament(M1);
			C1.addMedicament(M2);
			C2.addMedicament(M3);
			C2.addMedicament(M4);
			C2.addMedicament(M3);
			C3.addMedicament(M5);
			C3.addMedicament(M6);
			C3.addMedicament(M9);
			C3.addMedicament(M9);
			C3.addMedicament(M7);
			C4.addMedicament(M8);
			C4.addMedicament(M9);

			//Utilisations des méthodes d'affichages
			P1.afficher();
			P2.afficher();

			//Test de la méthode compteMedicament
			Console.WriteLine($"Le Medicament : {M3.IdMedicament} a été prescrit au patient {P1.NomPatient} " +
				$"{P1.compteMedicament(M3)} fois");
			Console.WriteLine($"Le Medicament : {M9.IdMedicament} a été prescrit au patient {P2.NomPatient} " +
				$"{P2.compteMedicament(M9)} fois");
			
			//Pause
			Console.Read();
		}
    }
}
