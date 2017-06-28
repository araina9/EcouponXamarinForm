using System;
using System.Collections.Generic;

namespace LoginNavigation.Models
{
    public class ECoupon
    {
        public Member member { get; set; }
        public List<Event> Events { get; set; }
		public List<Coupon> Coupons { get; set; }

		public class Member
		{
			public int? ID { get; set; }
			public int? MemberNo { get; set; }
			public string USERNAME { get; set; }
			public string EMAIL { get; set; }
			public string FIRSTNAME { get; set; }
			public string MIDDLENAME { get; set; }
			public string LASTNAME { get; set; }
			public string PERSONAL_ID { get; set; }
			public string PASSPORT_ID { get; set; }
			public string DOB { get; set; }
			public string HOME_TELNO { get; set; }
			public string MOBILENO { get; set; }
			public string ADDRESS1 { get; set; }
			public string ADDRESS2 { get; set; }
			public string POSTCODE { get; set; }
			public string BILLINGNAME { get; set; }
			public string BILLING_ADDRESS1 { get; set; }
			public string BILLING_ADDRESS2 { get; set; }
			public string BILLING_POSTCODE { get; set; }
			public string REMARKS { get; set; }
			public bool? ENABLED { get; set; }
			public string CREATED_DATETIME { get; set; }
			public string CREATED_BY { get; set; }
			public string UPDATED_DATETIME { get; set; }
			public string UPDATED_BY { get; set; }
			public string GENDER { get; set; }
		
		}

		public class Event
		{
			public int ID { get; set; }
			public string CODE { get; set; }
			public string NAME { get; set; }
			public string STARTPERIOD { get; set; }
			public string ENDPERIOD { get; set; }
		}

		public class Coupon
		{
			public int COUPON_ID { get; set; }
			public string CODE { get; set; }
			public int ORDER_ID { get; set; }
			public int MEMBER_ID { get; set; }
			public string USERNAME { get; set; }
			public string NAME { get; set; }
			public string PACKAGE_NAME { get; set; }
			public string STATUS { get; set; }
			public string DATE_PURCHASED { get; set; }
			public string DATE_EXPIRED { get; set; }
			public double TOTAL_PRICE { get; set; }
			public int AMOUNT { get; set; }
			public string EVENTNAME { get; set; }
		}
    }
}
