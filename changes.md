**Api changes**

<details>
<summary>Changed Property(s)</summary>

- :warning: changed property `discount` of type `DiscountedTotalPricePortion` from type `CartDiscountReference` to `Reference`
- :warning: changed property `exact` of type `SearchExactExpression` from type `SearchAnyValue` to `SearchExactValue`
</details>


<details>
<summary>Required Property(s)</summary>

- changed property `images` of type `ProductTailoringSetExternalImagesAction` to be optional
</details>


<details>
<summary>Added Property(s)</summary>

- added property `inheritedStores` to type `BusinessUnit`
- added property `inheritedStores` to type `Company`
- added property `inheritedStores` to type `Division`
- added property `applicationMode` to type `CartDiscountValueFixed`
- added property `applicationMode` to type `CartDiscountValueFixedDraft`
- added property `custom` to type `CartSetCustomShippingMethodAction`
- added property `custom` to type `StagedOrderSetCustomShippingMethodAction`
- added property `custom` to type `StagedOrderSetShippingAddressAndCustomShippingMethodAction`
- added property `businessUnits` to type `SearchIndexingConfiguration`
</details>


<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/business-units/search`
- added resource `/{projectKey}/business-units/search/indexing-status`
- added resource `/{projectKey}/channels/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units/key={key}`
- added resource `/{projectKey}/in-store/key={storeKey}/business-units/{ID}`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKey().businessUnits().search().post()`
- added method `apiRoot.withProjectKey().businessUnits().search().head()`
- added method `apiRoot.withProjectKey().businessUnits().searchIndexingStatus().get()`
- added method `apiRoot.withProjectKey().channels().withKey().get()`
- added method `apiRoot.withProjectKey().channels().withKey().head()`
- added method `apiRoot.withProjectKey().channels().withKey().post()`
- added method `apiRoot.withProjectKey().channels().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withKey().delete()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().get()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().head()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().post()`
- added method `apiRoot.withProjectKey().inStoreKeyWithStoreKeyValue().businessUnits().withId().delete()`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `BusinessUnitIndexingProgress`
- added type `BusinessUnitIndexingStatus`
- added type `BusinessUnitPagedSearchResponse`
- added type `BusinessUnitSearchIndexingStatusResponse`
- added type `BusinessUnitSearchRequest`
- added type `BusinessUnitSearchResult`
- added type `CartDiscountPatternTarget`
- added type `CountOnCustomLineItemUnits`
- added type `CountOnLineItemUnits`
- added type `PatternComponent`
- added type `ShoppingListLineItemAddedMessage`
- added type `ShoppingListLineItemRemovedMessage`
- added type `ShoppingListMessage`
- added type `ShoppingListLineItemAddedMessagePayload`
- added type `ShoppingListLineItemRemovedMessagePayload`
- added type `ShoppingListMessagePayload`
- added type `BusinessUnitSearchStatus`
- added type `ProjectChangeBusinessUnitSearchStatusAction`
- added type `SearchExactValue`
</details>


<details>
<summary>Added Enum(s)</summary>

- added enum `Canceled` to type `ShipmentState`
- added enum `shopping-list` to type `MessageSubscriptionResourceTypeId`
</details>

**Import changes**

<details>
<summary>Removed Type(s)</summary>

- :warning: removed type `ReferencedResourceNotFound`
</details>

**History changes**

<details>
<summary>Added Resource(s)</summary>

- added resource `/{projectKey}/graphql`
</details>


<details>
<summary>Added Method(s)</summary>

- added method `apiRoot.withProjectKeyValue().graphql().post()`
</details>


<details>
<summary>Added Type(s)</summary>

- added type `GraphQLRequest`
- added type `GraphQLResponse`
- added type `GraphQLError`
- added type `GraphQLErrorLocation`
- added type `GraphQLVariablesMap`
- added type `ChangeTargetPatternChangeValue`
- added type `PatternComponent`
</details>

