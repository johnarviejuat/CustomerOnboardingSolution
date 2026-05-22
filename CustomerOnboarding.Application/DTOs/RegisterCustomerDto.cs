namespace CustomerOnboarding.Application.DTOs
{
    public record RegisterCustomerDto(
        string FirstName,
        string LastName,
        string Email,
        string PhoneNumber,
        string SignatureBase64
    );
}
