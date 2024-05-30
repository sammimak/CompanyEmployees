namespace Shared.DataTransferObjects;

public record CompanyWithEmployeesDto : CompanyDto
{
    public IEnumerable<EmployeeForCreationDto> Employees { get; init; }
};