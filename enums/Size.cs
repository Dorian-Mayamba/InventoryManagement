namespace InventoryManagement.Enumerations
{
    public class Size : Enumeration
    {
        public static readonly Size XS = new Size(1, nameof(XS));
        public static readonly Size S = new Size(2, nameof(S));
        public static readonly Size M = new Size(3, nameof(M));
        public static readonly Size L = new Size(4, nameof(L));
        public static readonly Size XL = new Size(5, nameof(XL));
        public static readonly Size XXL = new Size(6, nameof(XXL));
        public Size(int id, string name) : base(id, name)
        {
        }
    }
}