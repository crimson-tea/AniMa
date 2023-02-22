namespace AniMa;

internal interface IRedoUndo<TOperation>
{
    internal void ExecuteRedo(TOperation operation);
    internal void ExecuteUndo(TOperation operation);
    internal void SetProgress(int step);
}
