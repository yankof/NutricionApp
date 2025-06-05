global using MediatR; // Nuevo
global using Microsoft.EntityFrameworkCore;
global using Microsoft.EntityFrameworkCore.Design;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.Logging;
global using Moq; // Nuevo: para crear un mock de IMediator (necesitarás el paquete NuGet Moq)
global using NutritionSystem.Application.Interfaces;
global using NutritionSystem.Application.Interfaces.Repositories;
global using NutritionSystem.Domain.Common;
global using NutritionSystem.Domain.Entities;
global using NutritionSystem.Infrastructure.Persistence;
global using System.Linq.Expressions;
global using System.Reflection;
