using BinhDinhFood.Domain.Constants;

namespace BinhDinhFood.Application.Common.Exceptions;

public static class ProgramException
{
    public static UserFriendlyException AppsettingNotSetException()
        => new(ErrorCode.Internal, ErrorMessage.AppConfigurationMessage, ErrorMessage.InternalError);
}
