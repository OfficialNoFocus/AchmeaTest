using TIC.DomainModel;
using TIC.WebAPI.Models.Responses;

namespace TIC.WebAPI.Mappers.Impl;

public class GetInsurancesResponseMapper : IGetInsurancesResponseMapper
{
    public GetInsurancesResponse Map(IEnumerable<Insurance> insurances)
    {
        return new GetInsurancesResponse
        {
            Name = insurances.Select(i => i.Name)
        };
    }
    public List<GetDutchTravelInsurancesResponse> Map(IEnumerable<TravelInsurance> insurances)
    {
        List<GetDutchTravelInsurancesResponse> responses = new List<GetDutchTravelInsurancesResponse>();

        foreach (TravelInsurance travelinsurance in insurances)
        {
            responses.Add(new GetDutchTravelInsurancesResponse
            {
                Name = travelinsurance.Name,
                Description = travelinsurance.Description,
                InsurancePremium = travelinsurance.InsurancePremium,
                InsuredAmount = travelinsurance.InsuredAmount,
            });
        }

        return responses;
    }
}