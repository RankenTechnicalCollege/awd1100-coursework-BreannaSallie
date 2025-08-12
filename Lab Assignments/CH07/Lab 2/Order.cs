namespace Lab_2
{
    public class Order
    {
        private short _itemNumber;
        private byte _quantity;
        private byte _estimatedDeliveryDays;

        public Order(short itemNumber, byte quantity, byte estimatedDeliveryDays)
        {
            ItemNumber = itemNumber;            // use setters (validates)
            Quantity = quantity;
            EstimatedDeliveryDays = estimatedDeliveryDays;
        }

        public short ItemNumber
        {
            get => _itemNumber;
            set
            {
                if (value < 100 || value > 999)
                    throw new InvalidItemNumberException("INVALID ITEM NUMBER");
                _itemNumber = value;
            }
        }

        public byte Quantity
        {
            get => _quantity;
            set
            {
                if (value < 1 || value > 12)
                    throw new InvalidQuantityException("INVALID QUANTITY");
                _quantity = value;
            }
        }

        public byte EstimatedDeliveryDays
        {
            get => _estimatedDeliveryDays;
            set
            {
                if (value < 1 || value > 30)
                    throw new InvalidDeliveryDaysException("INVALID DELIVERY DAYS");
                _estimatedDeliveryDays = value;
            }
        }
    }
}
