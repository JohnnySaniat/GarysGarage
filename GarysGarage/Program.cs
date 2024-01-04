using Garage;

Zero fxs = new Zero() {Name = "Zero", MainColor = "Blue"};
Tesla modelS = new Tesla() { Name = "Tesla", MainColor = "Purple"};
Cessna mx410 = new Cessna() { Name = "Cessna", MainColor = "Yellow"};
Ram br00 = new Ram() { Name = "Ram", MainColor = "Green"};

br00.Drive();
br00.Turn("left");
br00.Stop();

fxs.Drive();
fxs.Turn("straight");
fxs.Stop();

modelS.Drive();
modelS.Turn("up");
modelS.Stop();

mx410.Drive();
mx410.Turn("right");
mx410.Stop();