using System;

namespace Main
{
	public class Order :ActiveRecord
	{
		int MecicineID;
		int PrescriptionID;
		DateTime dataTime;
		int Amount;

		public Order(int mecicineID, int prescriptionID, DateTime dataTime, int amount)
		{
			MecicineID = mecicineID;
			PrescriptionID = prescriptionID;
			this.dataTime = dataTime;
			Amount = amount;
		}
	}
}
