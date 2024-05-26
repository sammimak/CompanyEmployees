
namespace Entities.Exceptions
{
    public  class EmployeeNotFoundException : Exception
    {
        public EmployeeNotFoundException(Guid employeeId): base($"Employee with id: {employeeId} doesn't exist in the database."){}
    }
}
