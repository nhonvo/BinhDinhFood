using BinhDinhFood.Domain.Constants;

namespace BinhDinhFood.Application.Common.Exceptions;

public static class TransactionException
{
    public static UserFriendlyException TransactionNotCommitException()
        => throw new UserFriendlyException(ErrorCode.Internal, ErrorMessage.TransactionNotCommit, ErrorMessage.TransactionNotCommit);

    public static UserFriendlyException TransactionNotExecuteException(Exception ex)
        => throw new UserFriendlyException(ErrorCode.Internal, ErrorMessage.TransactionNotExecute, ErrorMessage.TransactionNotExecute, ex);
}
