namespace Main
{
	public class Prescription :ActiveRecord
	{
		int ID;
		string CustomerName;
		string PESEL;
		string PrescriptionNumber;

		public Prescription(int id, string customerName, string pESEL, string prescriptionNumber)
		{
			ID = id;
			CustomerName = customerName;
			PESEL = pESEL;
			PrescriptionNumber = prescriptionNumber;
		}
	}
}
