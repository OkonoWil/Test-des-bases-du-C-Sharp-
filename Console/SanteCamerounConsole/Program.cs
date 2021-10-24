using System;

namespace SanteCamerounConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sante Cameroun";

			Patient P1 = new Patient("Samson");
			Patient P2 = new Patient("Jessica");


			Consultation C1 = new Consultation("Dr Donfack");
			Consultation C2 = new Consultation("Dr Okono");
			Consultation C3 = new Consultation("Dr Okono");
			Consultation C4 = new Consultation("Dr Donfack");


			Medicament M1 = new Medicament("Doliprane");
			Medicament M2 = new Medicament("Paracetamol");
			Medicament M3 = new Medicament("Efferalgan");
			Medicament M4 = new Medicament("Aspirine");
			Medicament M5 = new Medicament("Ascabiol lotion");
			Medicament M6 = new Medicament("Antibiotique");
			Medicament M7 = new Medicament("Vitamine C");
			Medicament M8 = new Medicament("Chabiothé");
			Medicament M9 = new Medicament("Voelkel");


			P1.addConsultation(C1);
			P1.addConsultation(C2);
			P2.addConsultation(C3);
			P2.addConsultation(C4);


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


			P1.afficher();
			P2.afficher();

			Console.WriteLine($"Le Medicament : {M3.IdMedicament} a été prescrit au patient {P1.NomPatient} " +
				$"{P1.compteMedicament(M3)} fois");
			Console.WriteLine($"Le Medicament : {M9.IdMedicament} a été prescrit au patient {P2.NomPatient} " +
				$"{P2.compteMedicament(M9)} fois");

			Console.Read();
			/*
			M9.affiche();
			System.out.println("Ce " + M9.getClass().getName() + " a été prescrit " + P2.compteMédicament(M9));
			M3.afficher();
			System.out.println("Ce " + M3.getClass().getName() + " a été prescrit " + P1.compteMédicament(M3));*/
		}
    }
}
