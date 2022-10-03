module OregonTrail.FSharp.GameState

type Request =
    | StartGame
    | DoYouRequireInstruction
    | HowMuchSpendOnOxen

type T =
    {
        IsGameFinished: bool;
        Request: Request;
        Text: string list;
        TurnNumber: int;
    }

let startingState =
    {
        IsGameFinished = false;
        Request = Request.StartGame;
        Text = List.empty;
        TurnNumber = 1;
    }