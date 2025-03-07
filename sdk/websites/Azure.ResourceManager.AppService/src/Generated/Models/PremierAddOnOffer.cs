// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Premier add-on offer. </summary>
    public partial class PremierAddOnOffer : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of PremierAddOnOffer. </summary>
        public PremierAddOnOffer()
        {
        }

        /// <summary> Initializes a new instance of PremierAddOnOffer. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="sku"> Premier add on SKU. </param>
        /// <param name="product"> Premier add on offer Product. </param>
        /// <param name="vendor"> Premier add on offer Vendor. </param>
        /// <param name="promoCodeRequired"> &lt;code&gt;true&lt;/code&gt; if promotion code is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="quota"> Premier add on offer Quota. </param>
        /// <param name="webHostingPlanRestrictions"> App Service plans this offer is restricted to. </param>
        /// <param name="privacyPolicyUrl"> Privacy policy URL. </param>
        /// <param name="legalTermsUrl"> Legal terms URL. </param>
        /// <param name="marketplacePublisher"> Marketplace publisher. </param>
        /// <param name="marketplaceOffer"> Marketplace offer. </param>
        internal PremierAddOnOffer(ResourceIdentifier id, string name, ResourceType type, string kind, string sku, string product, string vendor, bool? promoCodeRequired, int? quota, AppServicePlanRestrictions? webHostingPlanRestrictions, string privacyPolicyUrl, string legalTermsUrl, string marketplacePublisher, string marketplaceOffer) : base(id, name, type, kind)
        {
            Sku = sku;
            Product = product;
            Vendor = vendor;
            PromoCodeRequired = promoCodeRequired;
            Quota = quota;
            WebHostingPlanRestrictions = webHostingPlanRestrictions;
            PrivacyPolicyUrl = privacyPolicyUrl;
            LegalTermsUrl = legalTermsUrl;
            MarketplacePublisher = marketplacePublisher;
            MarketplaceOffer = marketplaceOffer;
        }

        /// <summary> Premier add on SKU. </summary>
        public string Sku { get; set; }
        /// <summary> Premier add on offer Product. </summary>
        public string Product { get; set; }
        /// <summary> Premier add on offer Vendor. </summary>
        public string Vendor { get; set; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if promotion code is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? PromoCodeRequired { get; set; }
        /// <summary> Premier add on offer Quota. </summary>
        public int? Quota { get; set; }
        /// <summary> App Service plans this offer is restricted to. </summary>
        public AppServicePlanRestrictions? WebHostingPlanRestrictions { get; set; }
        /// <summary> Privacy policy URL. </summary>
        public string PrivacyPolicyUrl { get; set; }
        /// <summary> Legal terms URL. </summary>
        public string LegalTermsUrl { get; set; }
        /// <summary> Marketplace publisher. </summary>
        public string MarketplacePublisher { get; set; }
        /// <summary> Marketplace offer. </summary>
        public string MarketplaceOffer { get; set; }
    }
}
