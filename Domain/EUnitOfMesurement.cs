using System.ComponentModel;

namespace supermarket.sharp.api.Domain
{
    public enum EUnitOfMesurement: byte
    {
        [Description("UN")]
        Unity = 1,
        
        [Description("MG")]
        Milligram = 2,
        
        [Description("G")]
        Gram = 3,
        
        [Description("KG")]
        Kilogram = 4,
        
        [Description("L")]
        Liter = 5
      
    }
}