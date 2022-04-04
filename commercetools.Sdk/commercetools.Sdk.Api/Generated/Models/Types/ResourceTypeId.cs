using System.ComponentModel;
using System.Linq;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;
namespace commercetools.Sdk.Api.Models.Types
{
    public enum ResourceTypeId
    {
        [Description("address")]
        Address,

        [Description("asset")]
        Asset,

        [Description("cart-discount")]
        CartDiscount,

        [Description("category")]
        Category,

        [Description("channel")]
        Channel,

        [Description("customer")]
        Customer,

        [Description("customer-group")]
        CustomerGroup,

        [Description("custom-line-item")]
        CustomLineItem,

        [Description("discount-code")]
        DiscountCode,

        [Description("inventory-entry")]
        InventoryEntry,

        [Description("line-item")]
        LineItem,

        [Description("order")]
        Order,

        [Description("order-edit")]
        OrderEdit,

        [Description("order-delivery")]
        OrderDelivery,

        [Description("payment")]
        Payment,

        [Description("payment-interface-interaction")]
        PaymentInterfaceInteraction,

        [Description("product-price")]
        ProductPrice,

        [Description("product-selection")]
        ProductSelection,

        [Description("review")]
        Review,

        [Description("shipping-method")]
        ShippingMethod,

        [Description("shopping-list")]
        ShoppingList,

        [Description("shopping-list-text-line-item")]
        ShoppingListTextLineItem,

        [Description("store")]
        Store,

        [Description("transaction")]
        Transaction
    }

    public class ResourceTypeIdWrapper : IResourceTypeId
    {
        public string JsonName { get; internal set; }
        public ResourceTypeId? Value { get; internal set; }
        public override string ToString()
        {
            return JsonName;
        }
    }

    [EnumInterfaceCreator(typeof(IResourceTypeId), "FindEnum")]
    public interface IResourceTypeId : IJsonName
    {
        public static IResourceTypeId Address = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Address, JsonName = "address" };

        public static IResourceTypeId Asset = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Asset, JsonName = "asset" };

        public static IResourceTypeId CartDiscount = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.CartDiscount, JsonName = "cart-discount" };

        public static IResourceTypeId Category = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Category, JsonName = "category" };

        public static IResourceTypeId Channel = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Channel, JsonName = "channel" };

        public static IResourceTypeId Customer = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Customer, JsonName = "customer" };

        public static IResourceTypeId CustomerGroup = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.CustomerGroup, JsonName = "customer-group" };

        public static IResourceTypeId CustomLineItem = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.CustomLineItem, JsonName = "custom-line-item" };

        public static IResourceTypeId DiscountCode = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.DiscountCode, JsonName = "discount-code" };

        public static IResourceTypeId InventoryEntry = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.InventoryEntry, JsonName = "inventory-entry" };

        public static IResourceTypeId LineItem = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.LineItem, JsonName = "line-item" };

        public static IResourceTypeId Order = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Order, JsonName = "order" };

        public static IResourceTypeId OrderEdit = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.OrderEdit, JsonName = "order-edit" };

        public static IResourceTypeId OrderDelivery = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.OrderDelivery, JsonName = "order-delivery" };

        public static IResourceTypeId Payment = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Payment, JsonName = "payment" };

        public static IResourceTypeId PaymentInterfaceInteraction = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.PaymentInterfaceInteraction, JsonName = "payment-interface-interaction" };

        public static IResourceTypeId ProductPrice = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ProductPrice, JsonName = "product-price" };

        public static IResourceTypeId ProductSelection = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ProductSelection, JsonName = "product-selection" };

        public static IResourceTypeId Review = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Review, JsonName = "review" };

        public static IResourceTypeId ShippingMethod = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ShippingMethod, JsonName = "shipping-method" };

        public static IResourceTypeId ShoppingList = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ShoppingList, JsonName = "shopping-list" };

        public static IResourceTypeId ShoppingListTextLineItem = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.ShoppingListTextLineItem, JsonName = "shopping-list-text-line-item" };

        public static IResourceTypeId Store = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Store, JsonName = "store" };

        public static IResourceTypeId Transaction = new ResourceTypeIdWrapper
        { Value = ResourceTypeId.Transaction, JsonName = "transaction" };

        ResourceTypeId? Value { get; }

        static IResourceTypeId[] Values()
        {
            return new[]
            {
                 Address ,
                 Asset ,
                 CartDiscount ,
                 Category ,
                 Channel ,
                 Customer ,
                 CustomerGroup ,
                 CustomLineItem ,
                 DiscountCode ,
                 InventoryEntry ,
                 LineItem ,
                 Order ,
                 OrderEdit ,
                 OrderDelivery ,
                 Payment ,
                 PaymentInterfaceInteraction ,
                 ProductPrice ,
                 ProductSelection ,
                 Review ,
                 ShippingMethod ,
                 ShoppingList ,
                 ShoppingListTextLineItem ,
                 Store ,
                 Transaction
             };
        }
        static IResourceTypeId FindEnum(string value)
        {
            return Values().FirstOrDefault(origin => origin.JsonName == value) ?? new ResourceTypeIdWrapper() { JsonName = value };
        }
    }
}
