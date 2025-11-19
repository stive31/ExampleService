using FluentValidation;

namespace Vk.Infrastructure.Validators;

internal abstract class BaseValidator<T> : AbstractValidator<T>
{
    //можно создать правила при которых будет валидироваться объект из бд и пробрасываться исключение если он не корректный
}
