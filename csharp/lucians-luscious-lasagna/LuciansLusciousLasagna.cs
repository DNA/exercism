class Lasagna
{
    const int TIME_PER_LAYER = 2;
    public int ExpectedMinutesInOven() => 40;

    public int RemainingMinutesInOven(int time) =>
        ExpectedMinutesInOven() - time;

    public int PreparationTimeInMinutes(int layers) =>
        TIME_PER_LAYER * layers;

    public int ElapsedTimeInMinutes(int layers, int time) =>
        PreparationTimeInMinutes(layers) + time;
}
