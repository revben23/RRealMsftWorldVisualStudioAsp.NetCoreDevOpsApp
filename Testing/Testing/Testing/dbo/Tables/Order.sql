﻿CREATE TABLE [dbo].[Order] (
    [Id]                                      INT              IDENTITY (1, 1) NOT NULL,
    [OrderGuid]                               UNIQUEIDENTIFIER NOT NULL,
    [StoreId]                                 INT              NOT NULL,
    [CustomerId]                              INT              NOT NULL,
    [BillingAddressId]                        INT              NOT NULL,
    [ShippingAddressId]                       INT              NULL,
    [PickupAddressId]                         INT              NULL,
    [PickUpInStore]                           BIT              NOT NULL,
    [OrderStatusId]                           INT              NOT NULL,
    [ShippingStatusId]                        INT              NOT NULL,
    [PaymentStatusId]                         INT              NOT NULL,
    [PaymentMethodSystemName]                 NVARCHAR (MAX)   NULL,
    [CustomerCurrencyCode]                    NVARCHAR (MAX)   NULL,
    [CurrencyRate]                            DECIMAL (18, 8)  NOT NULL,
    [CustomerTaxDisplayTypeId]                INT              NOT NULL,
    [VatNumber]                               NVARCHAR (MAX)   NULL,
    [OrderSubtotalInclTax]                    DECIMAL (18, 4)  NOT NULL,
    [OrderSubtotalExclTax]                    DECIMAL (18, 4)  NOT NULL,
    [OrderSubTotalDiscountInclTax]            DECIMAL (18, 4)  NOT NULL,
    [OrderSubTotalDiscountExclTax]            DECIMAL (18, 4)  NOT NULL,
    [OrderShippingInclTax]                    DECIMAL (18, 4)  NOT NULL,
    [OrderShippingExclTax]                    DECIMAL (18, 4)  NOT NULL,
    [PaymentMethodAdditionalFeeInclTax]       DECIMAL (18, 4)  NOT NULL,
    [PaymentMethodAdditionalFeeExclTax]       DECIMAL (18, 4)  NOT NULL,
    [TaxRates]                                NVARCHAR (MAX)   NULL,
    [OrderTax]                                DECIMAL (18, 4)  NOT NULL,
    [OrderDiscount]                           DECIMAL (18, 4)  NOT NULL,
    [OrderTotal]                              DECIMAL (18, 4)  NOT NULL,
    [RefundedAmount]                          DECIMAL (18, 4)  NOT NULL,
    [RewardPointsHistoryEntryId]              INT              NULL,
    [CheckoutAttributeDescription]            NVARCHAR (MAX)   NULL,
    [CheckoutAttributesXml]                   NVARCHAR (MAX)   NULL,
    [CustomerLanguageId]                      INT              NOT NULL,
    [AffiliateId]                             INT              NOT NULL,
    [CustomerIp]                              NVARCHAR (MAX)   NULL,
    [AllowStoringCreditCardNumber]            BIT              NOT NULL,
    [CardType]                                NVARCHAR (MAX)   NULL,
    [CardName]                                NVARCHAR (MAX)   NULL,
    [CardNumber]                              NVARCHAR (MAX)   NULL,
    [MaskedCreditCardNumber]                  NVARCHAR (MAX)   NULL,
    [CardCvv2]                                NVARCHAR (MAX)   NULL,
    [CardExpirationMonth]                     NVARCHAR (MAX)   NULL,
    [CardExpirationYear]                      NVARCHAR (MAX)   NULL,
    [AuthorizationTransactionId]              NVARCHAR (MAX)   NULL,
    [AuthorizationTransactionCode]            NVARCHAR (MAX)   NULL,
    [AuthorizationTransactionResult]          NVARCHAR (MAX)   NULL,
    [CaptureTransactionId]                    NVARCHAR (MAX)   NULL,
    [CaptureTransactionResult]                NVARCHAR (MAX)   NULL,
    [SubscriptionTransactionId]               NVARCHAR (MAX)   NULL,
    [PaidDateUtc]                             DATETIME         NULL,
    [ShippingMethod]                          NVARCHAR (MAX)   NULL,
    [ShippingRateComputationMethodSystemName] NVARCHAR (MAX)   NULL,
    [CustomValuesXml]                         NVARCHAR (MAX)   NULL,
    [Deleted]                                 BIT              NOT NULL,
    [CreatedOnUtc]                            DATETIME         NOT NULL,
    [CustomOrderNumber]                       NVARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [Order_BillingAddress] FOREIGN KEY ([BillingAddressId]) REFERENCES [dbo].[Address] ([Id]),
    CONSTRAINT [Order_Customer] FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [Order_PickupAddress] FOREIGN KEY ([PickupAddressId]) REFERENCES [dbo].[Address] ([Id]),
    CONSTRAINT [Order_ShippingAddress] FOREIGN KEY ([ShippingAddressId]) REFERENCES [dbo].[Address] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Order_CustomerId]
    ON [dbo].[Order]([CustomerId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Order_CreatedOnUtc]
    ON [dbo].[Order]([CreatedOnUtc] DESC);

