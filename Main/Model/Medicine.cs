namespace Main
{
	public class Medicine :ActiveRecord
	{
		int ID;
		string Name;
		string Manufacturer;
		decimal Price;
		int Almount;
		bool WithPrescription;

		public Medicine(int iD, string name, string manufacturer, decimal price, int almount, bool withPrescription)
		{
			ID = iD;
			Name = name;
			Manufacturer = manufacturer;
			Price = price;
			Almount = almount;
			WithPrescription = withPrescription;
		}
	}
}
