namespace FullSD_Project_FoodCapybara.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string RestaurantsEndpoint = $"{Prefix}/restaurants";
        public static readonly string FoodsEndpoint = $"{Prefix}/foods";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string OrderItemsEndpoint = $"{Prefix}/orderitems";
        public static readonly string PaymentsEndpoint = $"{Prefix}/payments";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string CustomersEndpoint = $"{Prefix}/customers";

    }
}
