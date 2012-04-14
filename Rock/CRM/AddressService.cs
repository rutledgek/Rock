//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System;
using System.Collections.Generic;
using System.Linq;

using Rock.Data;

namespace Rock.CRM
{
	/// <summary>
	/// Address POCO Service Layer class
	/// </summary>
    public partial class AddressService : Service<Rock.CRM.Address>
    {
		/// <summary>
		/// Gets Address by Street 1 And Street 2 And City And State And Zip
		/// </summary>
		/// <param name="street1">Street 1.</param>
		/// <param name="street2">Street 2.</param>
		/// <param name="city">City.</param>
		/// <param name="state">State.</param>
		/// <param name="zip">Zip.</param>
		/// <returns>Address object.</returns>
	    public Rock.CRM.Address GetByStreet1AndStreet2AndCityAndStateAndZip( string street1, string street2, string city, string state, string zip )
        {
            return Repository.FirstOrDefault( t => ( t.Street1 == street1 || ( street1 == null && t.Street1 == null ) ) && ( t.Street2 == street2 || ( street2 == null && t.Street2 == null ) ) && ( t.City == city || ( city == null && t.City == null ) ) && ( t.State == state || ( state == null && t.State == null ) ) && ( t.Zip == zip || ( zip == null && t.Zip == null ) ) );
        }
		
		/// <summary>
		/// Gets Address by Raw
		/// </summary>
		/// <param name="raw">Raw.</param>
		/// <returns>Address object.</returns>
	    public Rock.CRM.Address GetByRaw( string raw )
        {
            return Repository.FirstOrDefault( t => ( t.Raw == raw || ( raw == null && t.Raw == null ) ) );
        }
		
    }
}
