using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Products
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Products.ProductUpdateAction))]
    [SubTypeDiscriminator("addAsset", typeof(commercetools.Sdk.Api.Models.Products.ProductAddAssetAction))]
    [SubTypeDiscriminator("addExternalImage", typeof(commercetools.Sdk.Api.Models.Products.ProductAddExternalImageAction))]
    [SubTypeDiscriminator("addPrice", typeof(commercetools.Sdk.Api.Models.Products.ProductAddPriceAction))]
    [SubTypeDiscriminator("addToCategory", typeof(commercetools.Sdk.Api.Models.Products.ProductAddToCategoryAction))]
    [SubTypeDiscriminator("addVariant", typeof(commercetools.Sdk.Api.Models.Products.ProductAddVariantAction))]
    [SubTypeDiscriminator("changeAssetName", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeAssetNameAction))]
    [SubTypeDiscriminator("changeAssetOrder", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeAssetOrderAction))]
    [SubTypeDiscriminator("changeMasterVariant", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeMasterVariantAction))]
    [SubTypeDiscriminator("changeName", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeNameAction))]
    [SubTypeDiscriminator("changePrice", typeof(commercetools.Sdk.Api.Models.Products.ProductChangePriceAction))]
    [SubTypeDiscriminator("changeSlug", typeof(commercetools.Sdk.Api.Models.Products.ProductChangeSlugAction))]
    [SubTypeDiscriminator("legacySetSku", typeof(commercetools.Sdk.Api.Models.Products.ProductLegacySetSkuAction))]
    [SubTypeDiscriminator("moveImageToPosition", typeof(commercetools.Sdk.Api.Models.Products.ProductMoveImageToPositionAction))]
    [SubTypeDiscriminator("publish", typeof(commercetools.Sdk.Api.Models.Products.ProductPublishAction))]
    [SubTypeDiscriminator("removeAsset", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveAssetAction))]
    [SubTypeDiscriminator("removeFromCategory", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveFromCategoryAction))]
    [SubTypeDiscriminator("removeImage", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveImageAction))]
    [SubTypeDiscriminator("removePrice", typeof(commercetools.Sdk.Api.Models.Products.ProductRemovePriceAction))]
    [SubTypeDiscriminator("removeVariant", typeof(commercetools.Sdk.Api.Models.Products.ProductRemoveVariantAction))]
    [SubTypeDiscriminator("revertStagedChanges", typeof(commercetools.Sdk.Api.Models.Products.ProductRevertStagedChangesAction))]
    [SubTypeDiscriminator("revertStagedVariantChanges", typeof(commercetools.Sdk.Api.Models.Products.ProductRevertStagedVariantChangesAction))]
    [SubTypeDiscriminator("setAssetCustomField", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomFieldAction))]
    [SubTypeDiscriminator("setAssetCustomType", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetCustomTypeAction))]
    [SubTypeDiscriminator("setAssetDescription", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetDescriptionAction))]
    [SubTypeDiscriminator("setAssetKey", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetKeyAction))]
    [SubTypeDiscriminator("setAssetSources", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetSourcesAction))]
    [SubTypeDiscriminator("setAssetTags", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAssetTagsAction))]
    [SubTypeDiscriminator("setAttribute", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAttributeAction))]
    [SubTypeDiscriminator("setAttributeInAllVariants", typeof(commercetools.Sdk.Api.Models.Products.ProductSetAttributeInAllVariantsAction))]
    [SubTypeDiscriminator("setCategoryOrderHint", typeof(commercetools.Sdk.Api.Models.Products.ProductSetCategoryOrderHintAction))]
    [SubTypeDiscriminator("setDescription", typeof(commercetools.Sdk.Api.Models.Products.ProductSetDescriptionAction))]
    [SubTypeDiscriminator("setDiscountedPrice", typeof(commercetools.Sdk.Api.Models.Products.ProductSetDiscountedPriceAction))]
    [SubTypeDiscriminator("setImageLabel", typeof(commercetools.Sdk.Api.Models.Products.ProductSetImageLabelAction))]
    [SubTypeDiscriminator("setKey", typeof(commercetools.Sdk.Api.Models.Products.ProductSetKeyAction))]
    [SubTypeDiscriminator("setMetaDescription", typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaDescriptionAction))]
    [SubTypeDiscriminator("setMetaKeywords", typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaKeywordsAction))]
    [SubTypeDiscriminator("setMetaTitle", typeof(commercetools.Sdk.Api.Models.Products.ProductSetMetaTitleAction))]
    [SubTypeDiscriminator("setPriceMode", typeof(commercetools.Sdk.Api.Models.Products.ProductSetPriceModeAction))]
    [SubTypeDiscriminator("setPrices", typeof(commercetools.Sdk.Api.Models.Products.ProductSetPricesAction))]
    [SubTypeDiscriminator("setProductPriceCustomField", typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomFieldAction))]
    [SubTypeDiscriminator("setProductPriceCustomType", typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductPriceCustomTypeAction))]
    [SubTypeDiscriminator("setProductVariantKey", typeof(commercetools.Sdk.Api.Models.Products.ProductSetProductVariantKeyAction))]
    [SubTypeDiscriminator("setSearchKeywords", typeof(commercetools.Sdk.Api.Models.Products.ProductSetSearchKeywordsAction))]
    [SubTypeDiscriminator("setSku", typeof(commercetools.Sdk.Api.Models.Products.ProductSetSkuAction))]
    [SubTypeDiscriminator("setTaxCategory", typeof(commercetools.Sdk.Api.Models.Products.ProductSetTaxCategoryAction))]
    [SubTypeDiscriminator("transitionState", typeof(commercetools.Sdk.Api.Models.Products.ProductTransitionStateAction))]
    [SubTypeDiscriminator("unpublish", typeof(commercetools.Sdk.Api.Models.Products.ProductUnpublishAction))]
    public partial interface IProductUpdateAction : commercetools.Sdk.Api.Models.IResourceUpdateAction<IProductUpdateAction>
    {
        new string Action { get; set; }
    }
}
