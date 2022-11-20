using OOPThree;

NeedCreditManager needCreditManager = new NeedCreditManager();
needCreditManager.Calculate();

VehicleCreditManager vehicleCreditManager = new VehicleCreditManager();
vehicleCreditManager.Calculate();

HousingCreditManager housingCreditManager = new HousingCreditManager();

housingCreditManager.Calculate();


RecourseManager recourseManager=new RecourseManager();

recourseManager.RecourseDo(vehicleCreditManager, new FileLoggerService());

List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager };

//recourseManager.CreditPreliminaryInformation(credits);