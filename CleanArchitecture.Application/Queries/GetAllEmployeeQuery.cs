using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Queries
{
    public class GetAllEmployeeQuery : IRequest<List<Employee>>
    {
    }
}
