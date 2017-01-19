// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MVP.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// The activity view model.
    /// Note:
    /// The logic of acticity is a little complicate.
    /// While edit activity, the ActivityType should be non-editable;
    /// While add activity, the dispalyname of
    /// AnnualQuantity/SecondAnnualQuantity/ReachScore should change with
    /// ActivityType changing,
    /// and validation rule is different while ActivityType change.
    /// Following is the logic details.
    /// &lt;remarks&gt;
    /// Book (Author):
    /// [msft_title: required, 'Title']
    /// [msft_startdate: required,'Start Date']
    /// [msft_annualquantity: required, 'Books']
    /// Book (Co-Author): same as Book (Author)
    /// Conference (booth presenter):
    /// [msft_title: required, 'Title']
    /// [msft_startdate: required,'Start Date']
    /// [msft_annualquantity: required, 'Conferences']
    /// Conference (organizer): same as Conference (booth presenter)
    /// Speaking (Conference):
    /// [msft_title: required, 'Title']
    /// [msft_startdate: required,'Start Date']
    /// [msft_annualquantity: required, 'Talks']
    /// Speaking (Local):Same as Speaking (Conference)
    /// Speaking (User group):Same as Speaking (Conference)
    /// Forum Moderator:
    /// [msft_title: required, 'Title']
    /// [msft_startdate: required,'Start Date']
    /// [msft_annualquantity: required, 'Threads Moderated']
    /// Forum Participation (Microsoft Forums):
    /// [msft_title: recommend, 'Title']
    /// [msft_startdate: required,'Start Date']
    /// [msft_url: required, 'Url']
    /// [msft_annualquantity: required, 'Answers']
    /// Forum Participation (3rd Party forums):
    /// [msft_title: recommend, 'Title']
    /// [msft_startdate: required,'Start Date']
    /// [msft_url: required, 'Url']
    /// [msft_annualquantity: required, 'Answers']
    /// [msft_secondannualquantity: required, 'Posts']
    /// &lt;/remarks&gt;
    /// </summary>
    public partial class ActivityViewModel
    {
        /// <summary>
        /// Initializes a new instance of the ActivityViewModel class.
        /// </summary>
        public ActivityViewModel() { }

        /// <summary>
        /// Initializes a new instance of the ActivityViewModel class.
        /// </summary>
        public ActivityViewModel(ActivityTypeViewModel activityType, ActivityTechnologyViewModel applicableTechnology, DateTime dateOfActivity, string titleOfActivity, int? privateSiteId = default(int?), string dateOfActivityFormatted = default(string), DateTime? endDate = default(DateTime?), string endDateFormatted = default(string), string referenceUrl = default(string), VisibilityViewModel activityVisibility = default(VisibilityViewModel), int? annualQuantity = default(int?), int? secondAnnualQuantity = default(int?), int? annualReach = default(int?), string description = default(string), OnlineIdentityViewModel onlineIdentity = default(OnlineIdentityViewModel), SocialNetworkViewModel socialNetwork = default(SocialNetworkViewModel), string allAnswersUrl = default(string), string allPostsUrl = default(string), bool? isSystemCollected = default(bool?), bool? isBelongToLatestAwardCycle = default(bool?), string displayMode = default(string), IList<int?> chartColumnIndexes = default(IList<int?>), string descriptionSummaryFormat = default(string), string dataTableTitle = default(string), string subtitleHeader = default(string), bool? isAllowEdit = default(bool?), bool? isAllowDelete = default(bool?), bool? isFromBookmarklet = default(bool?), bool? submitted = default(bool?))
        {
            PrivateSiteId = privateSiteId;
            ActivityType = activityType;
            ApplicableTechnology = applicableTechnology;
            DateOfActivity = dateOfActivity;
            DateOfActivityFormatted = dateOfActivityFormatted;
            EndDate = endDate;
            EndDateFormatted = endDateFormatted;
            TitleOfActivity = titleOfActivity;
            ReferenceUrl = referenceUrl;
            ActivityVisibility = activityVisibility;
            AnnualQuantity = annualQuantity;
            SecondAnnualQuantity = secondAnnualQuantity;
            AnnualReach = annualReach;
            Description = description;
            OnlineIdentity = onlineIdentity;
            SocialNetwork = socialNetwork;
            AllAnswersUrl = allAnswersUrl;
            AllPostsUrl = allPostsUrl;
            IsSystemCollected = isSystemCollected;
            IsBelongToLatestAwardCycle = isBelongToLatestAwardCycle;
            DisplayMode = displayMode;
            ChartColumnIndexes = chartColumnIndexes;
            DescriptionSummaryFormat = descriptionSummaryFormat;
            DataTableTitle = dataTableTitle;
            SubtitleHeader = subtitleHeader;
            IsAllowEdit = isAllowEdit;
            IsAllowDelete = isAllowDelete;
            IsFromBookmarklet = isFromBookmarklet;
            Submitted = submitted;
        }

        /// <summary>
        /// Gets or sets the private site id.
        /// </summary>
        [JsonProperty(PropertyName = "PrivateSiteId")]
        public int? PrivateSiteId { get; set; }

        /// <summary>
        /// Gets or sets the contribution type.
        /// </summary>
        [JsonProperty(PropertyName = "ActivityType")]
        public ActivityTypeViewModel ActivityType { get; set; }

        /// <summary>
        /// Gets or sets the contribution technology.
        /// </summary>
        [JsonProperty(PropertyName = "ApplicableTechnology")]
        public ActivityTechnologyViewModel ApplicableTechnology { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [JsonProperty(PropertyName = "DateOfActivity")]
        public DateTime DateOfActivity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DateOfActivityFormatted")]
        public string DateOfActivityFormatted { get; set; }

        /// <summary>
        /// End Date for system auto contribution
        /// </summary>
        [JsonProperty(PropertyName = "EndDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndDateFormatted")]
        public string EndDateFormatted { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty(PropertyName = "TitleOfActivity")]
        public string TitleOfActivity { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonProperty(PropertyName = "ReferenceUrl")]
        public string ReferenceUrl { get; set; }

        /// <summary>
        /// Gets or sets the visibility.
        /// </summary>
        [JsonProperty(PropertyName = "ActivityVisibility")]
        public VisibilityViewModel ActivityVisibility { get; set; }

        /// <summary>
        /// Gets or sets the annual quantity.
        /// </summary>
        [JsonProperty(PropertyName = "AnnualQuantity")]
        public int? AnnualQuantity { get; set; }

        /// <summary>
        /// Gets or sets the second annual quantity.
        /// </summary>
        [JsonProperty(PropertyName = "SecondAnnualQuantity")]
        public int? SecondAnnualQuantity { get; set; }

        /// <summary>
        /// Gets or sets the reach score.
        /// </summary>
        [JsonProperty(PropertyName = "AnnualReach")]
        public int? AnnualReach { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// Online identity by which this contribution was collected. Should
        /// be null if the contribution was not system collected
        /// </summary>
        [JsonProperty(PropertyName = "OnlineIdentity")]
        public OnlineIdentityViewModel OnlineIdentity { get; set; }

        /// <summary>
        /// Social network. Should be null or ignore for non system collected
        /// contribution
        /// </summary>
        [JsonProperty(PropertyName = "SocialNetwork")]
        public SocialNetworkViewModel SocialNetwork { get; set; }

        /// <summary>
        /// AllAnswersUrl
        /// </summary>
        [JsonProperty(PropertyName = "AllAnswersUrl")]
        public string AllAnswersUrl { get; set; }

        /// <summary>
        /// AllAnswersUrl
        /// </summary>
        [JsonProperty(PropertyName = "AllPostsUrl")]
        public string AllPostsUrl { get; set; }

        /// <summary>
        /// If this contribution is system collected
        /// </summary>
        [JsonProperty(PropertyName = "IsSystemCollected")]
        public bool? IsSystemCollected { get; set; }

        /// <summary>
        /// If this contribution belongs to latest award cycle.
        /// </summary>
        [JsonProperty(PropertyName = "IsBelongToLatestAwardCycle")]
        public bool? IsBelongToLatestAwardCycle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayMode")]
        public string DisplayMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChartColumnIndexes")]
        public IList<int?> ChartColumnIndexes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DescriptionSummaryFormat")]
        public string DescriptionSummaryFormat { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DataTableTitle")]
        public string DataTableTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SubtitleHeader")]
        public string SubtitleHeader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAllowEdit")]
        public bool? IsAllowEdit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsAllowDelete")]
        public bool? IsAllowDelete { get; set; }

        /// <summary>
        /// IsBookmarklet: If the call is initiated from bookmarklet
        /// </summary>
        [JsonProperty(PropertyName = "IsFromBookmarklet")]
        public bool? IsFromBookmarklet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Submitted")]
        public bool? Submitted { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (ActivityType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ActivityType");
            }
            if (ApplicableTechnology == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ApplicableTechnology");
            }
            if (TitleOfActivity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TitleOfActivity");
            }
            if (this.ApplicableTechnology != null)
            {
                this.ApplicableTechnology.Validate();
            }
            if (this.ReferenceUrl != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.ReferenceUrl, "^((https?|ftp):\\/\\/)?(((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:)*@)?(((\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5]))|((([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?)(:\\d*)?)(\\/((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)+(\\/(([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)*)*)?)?(\\?((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|[\\uE000-\\uF8FF]|\\/|\\?)*)?(\\#((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|\\/|\\?)*)?$"))
                {
                    throw new ValidationException(ValidationRules.Pattern, "ReferenceUrl", "^((https?|ftp):\\/\\/)?(((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:)*@)?(((\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d|[1-9]\\d|1\\d\\d|2[0-4]\\d|25[0-5]))|((([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|\\d|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.)+(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])*([a-zA-Z]|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])))\\.?)(:\\d*)?)(\\/((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)+(\\/(([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)*)*)?)?(\\?((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|[\\uE000-\\uF8FF]|\\/|\\?)*)?(\\#((([a-zA-Z]|\\d|-|\\.|_|~|[\\u00A0-\\uD7FF\\uF900-\\uFDCF\\uFDF0-\\uFFEF])|(%[\\da-fA-F]{2})|[!\\$&amp;'\\(\\)\\*\\+,;=]|:|@)|\\/|\\?)*)?$");
                }
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.AnnualQuantity, "^[0-9]*$"))
            {
                throw new ValidationException(ValidationRules.Pattern, "AnnualQuantity", "^[0-9]*$");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.SecondAnnualQuantity, "^[0-9]*$"))
            {
                throw new ValidationException(ValidationRules.Pattern, "SecondAnnualQuantity", "^[0-9]*$");
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(this.AnnualReach, "^[0-9]*$"))
            {
                throw new ValidationException(ValidationRules.Pattern, "AnnualReach", "^[0-9]*$");
            }
            if (this.OnlineIdentity != null)
            {
                this.OnlineIdentity.Validate();
            }
            if (this.SocialNetwork != null)
            {
                this.SocialNetwork.Validate();
            }
        }
    }
}
