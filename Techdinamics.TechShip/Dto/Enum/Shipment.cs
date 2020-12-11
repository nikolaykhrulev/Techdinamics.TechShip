namespace Techdinamics.TechShip.Dto.Enum
{
	public enum FreightPaymentTerms
	{
		Prepaid = 0,
		Collect = 1,
		ThirdParty = 2
	}

	public enum Type
	{
		PDF = 1,
		ZPL = 2,
		PNG = 3
	}

	public enum Purpose
	{
		LABEL,
		RETURNLABEL,
		COMMERCIALINVOICE,
		CODREMITTANCELABEL,
		PACKINGSLIP
	}
}
