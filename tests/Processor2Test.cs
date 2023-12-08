namespace tests;

[TestClass]
public class Processor2Test : code.Processor2
{
  [TestMethod]
  public void GetNodeStartWithATest()
  {
    string input = @"LR

11A = (11B, XXX)
11B = (XXX, 11Z)
11Z = (11B, XXX)
22A = (22B, XXX)
22B = (22C, 22C)
22C = (22Z, 22Z)
22Z = (22B, 22B)
XXX = (XXX, XXX)";
    Dictionary<string, (string, string)> maps = code.InputHandler.ReadInputMap(input);

    List<string> expected = ["11A", "22A"];
    List<string> actual = code.Processor2.GetAllNodesEndWithA(maps);
    CollectionAssert.AreEqual(expected, actual);
  }
  [TestMethod]
  public void GetArrivedAtsTest()
  {
    string input = @"LR

11A = (11B, XXX)
11B = (XXX, 11Z)
11Z = (11B, XXX)
22A = (22B, XXX)
22B = (22C, 22C)
22C = (22Z, 22Z)
22Z = (22B, 22B)
XXX = (XXX, XXX)";
    Dictionary<string, (string, string)> maps = code.InputHandler.ReadInputMap(input);
    List<string> startAts = ["11A", "22A"];
    char instruction = 'L';
    List<string> actual = code.Processor2.GetArrivedAts(startAts, instruction, maps);
    List<string> expected = ["11B", "22B"];

    CollectionAssert.AreEqual(expected, actual);
  }
  [TestMethod]
  public void StepTest1()
  {
    string input = @"LR

  11A = (11B, XXX)
  11B = (XXX, 11Z)
  11Z = (11B, XXX)
  22A = (22B, XXX)
  22B = (22C, 22C)
  22C = (22Z, 22Z)
  22Z = (22B, 22B)
  XXX = (XXX, XXX)";

    long expected = 6;
    long actual = code.Processor2.Process(input);
    Assert.AreEqual(expected, actual);
  }


        [TestMethod]
    public void GetQ2AnswerTest()
    {
      string input = @"LRRLRRRLLRRRLRRRLLRRLRRRLRRLRRLRLRLRLRLRLLRRRLRRLRLRRRLRRRLRLRRRLRLRRLRRRLRRRLRLLRRRLRLLLRLRRRLRLRRLRRLLLLRRLRRLRLRLRRLRLRRLRRRLRRRLRLRLRRLLLLRRLRLRRLLRRRLRLRLRLRRRLRLLLRLRLRRRLRLRRRLRRRLRRRLLRRLRRRLRRRLRRRLRRRLRLLRRRLRLRRRLRLRLRRRLRRLRRLLRRRLRRRLRRRLRLRLRLRRLRRRLRRLRLRLRLRRRR

  TJF = (TXF, NGK)
  PDL = (TXD, FRT)
  MVB = (HLF, BMQ)
  LKG = (JTG, THR)
  MPN = (CKC, FKR)
  HHN = (HFV, FGD)
  TMM = (GJG, CCJ)
  HJD = (PHB, FJM)
  JNC = (NMB, SND)
  HHR = (NBB, HMD)
  KCC = (BHB, PDC)
  CKN = (FRD, TQK)
  NCG = (VSC, PTD)
  QFP = (BHQ, KFT)
  HRG = (VPV, HPP)
  XSK = (PCS, BDP)
  GJM = (QPQ, RQN)
  RKJ = (NTS, GLH)
  SKK = (QGR, RBB)
  HBK = (CBC, HKX)
  PNM = (HRG, KPJ)
  KQK = (DMK, HTJ)
  BBS = (KDC, FCX)
  PJF = (MVB, CQL)
  JPX = (PRD, LFG)
  KQT = (XJM, RGQ)
  RVJ = (LKS, QVN)
  TJD = (SCM, RBL)
  CCJ = (TQM, FQM)
  FJD = (VGF, FLP)
  LVG = (XHG, GBF)
  JJP = (LMP, XXF)
  FGD = (KQT, NDX)
  SKL = (THR, JTG)
  HBM = (GMS, HCM)
  NHL = (KLX, XKB)
  PPD = (PSR, FMS)
  TQV = (DHP, GLL)
  FVC = (SGH, KPC)
  MCA = (MRC, RMJ)
  FSL = (SKT, RQP)
  JCT = (XRJ, LTL)
  LMS = (TLP, CDP)
  XKB = (NXQ, QJH)
  KDQ = (CRC, SXC)
  KML = (RCL, SVM)
  DFP = (PSP, NPV)
  JTQ = (CGV, JNC)
  MSD = (VRQ, RLK)
  FRT = (BCK, XPX)
  NTK = (JTJ, NMP)
  QCR = (KFT, BHQ)
  HJK = (LQG, PSN)
  FJG = (NTR, TXB)
  NFL = (BDV, HHN)
  RPB = (CGN, PFT)
  PFT = (MFH, MVK)
  SKT = (CTB, CJL)
  DFR = (XJD, GLD)
  JJS = (KNM, MQQ)
  KDV = (LFX, BRQ)
  JSV = (MCD, VTB)
  BGH = (NTS, GLH)
  HVN = (BNH, LPH)
  NQT = (LXR, LXS)
  PGV = (JMR, NBV)
  VHC = (LXP, RVL)
  JGS = (TJS, NMV)
  NXQ = (CKN, SSJ)
  THR = (HNX, VBT)
  LQF = (MRC, RMJ)
  LBL = (QGG, PXV)
  VQD = (FTS, TKG)
  HCP = (CFF, FRJ)
  RCL = (GRJ, MVT)
  NKD = (HXR, JQX)
  PDV = (TJD, PFX)
  TTT = (GJG, CCJ)
  HFV = (KQT, NDX)
  SHB = (DHD, JNM)
  HPP = (BHM, PDV)
  DKM = (VVV, PKG)
  RSN = (QNN, PMC)
  RPN = (CKC, FKR)
  TBH = (NMR, HHG)
  FCF = (MRL, LBK)
  LLJ = (QGG, PXV)
  KFJ = (GPL, BFF)
  MSR = (SPF, XNP)
  XGX = (FDL, HHP)
  DQV = (PVX, PVX)
  BCK = (DLP, QPX)
  FBV = (LFN, XGX)
  CDH = (LJF, CMM)
  DPS = (QFL, JDG)
  MKX = (LCB, LSR)
  NHP = (JRX, PPJ)
  PVP = (HQD, MJL)
  RRK = (PXG, DPH)
  QQS = (DNF, TQF)
  QRD = (PGV, HRR)
  VKP = (QXL, MTX)
  XVF = (VQD, KFF)
  KHP = (KXJ, PCX)
  VTF = (DNJ, NHP)
  LMP = (RGD, RGD)
  VMT = (HTJ, DMK)
  VQJ = (VFG, QGX)
  PHK = (TFG, MJT)
  JFN = (HSF, PCL)
  GJF = (VQF, MHP)
  QFL = (TDN, CLJ)
  RKS = (KFJ, SCF)
  DVX = (MJJ, CKP)
  SFT = (DVX, CTX)
  PTX = (DJV, QCT)
  HTX = (DSN, NKD)
  RKM = (RJD, TVM)
  BBQ = (QBM, HVR)
  TQH = (KHB, NJP)
  HHG = (JFT, PDL)
  DHP = (CDH, BPQ)
  TCC = (LBR, NCG)
  SKC = (JDQ, MTC)
  DNH = (QGP, HLT)
  KMT = (KBS, JLK)
  TFR = (XKN, RTK)
  RRH = (XQL, HBL)
  HDL = (VDM, LSF)
  NXP = (BDT, CTG)
  PRB = (TQV, PMV)
  TXB = (PTK, TBH)
  DDP = (PJX, LMS)
  RXN = (PPS, BVB)
  CTG = (DFR, FVK)
  PDC = (PNM, CHG)
  LVD = (TQF, DNF)
  FDF = (BBQ, TPJ)
  HSF = (DMS, JSR)
  DNJ = (PPJ, JRX)
  BDD = (QFP, QCR)
  BHJ = (SDD, HCP)
  GMS = (GGJ, FXM)
  RFH = (LCP, KFG)
  MVT = (JHF, TJB)
  SCM = (RNC, FJQ)
  JLK = (HBX, CFQ)
  GKS = (DDC, JPB)
  BFF = (CVM, TJF)
  GSX = (TSD, FVC)
  JQR = (CPM, TDK)
  HTJ = (FCF, RXQ)
  NSN = (SHL, TKT)
  CMJ = (GNB, XDV)
  FCN = (SLP, XCF)
  FTG = (NDK, MPV)
  RMR = (TKQ, MSR)
  LXP = (VKP, CXG)
  FHT = (QQM, NHL)
  DPH = (SSB, DVS)
  TPJ = (QBM, HVR)
  GGD = (GPT, HNC)
  TGB = (FBH, TDS)
  KFX = (BNH, LPH)
  HMM = (QBV, JGS)
  SVS = (RFX, FDK)
  DQQ = (LPF, VLS)
  TJS = (BKQ, RKM)
  CLJ = (KRR, NXP)
  NQN = (HXC, GPP)
  BMC = (VTB, MCD)
  DCR = (MNJ, GST)
  MBB = (NMP, JTJ)
  MVH = (NTR, TXB)
  MCD = (HMM, JDJ)
  NHR = (BSP, PSL)
  DLG = (TCS, KKM)
  HPQ = (JDV, LSG)
  XKG = (LBR, NCG)
  FKD = (LGK, LBJ)
  KBS = (CFQ, HBX)
  QMC = (DNJ, NHP)
  CTR = (PDH, KBB)
  RFX = (XJS, QRF)
  DMZ = (LKT, RMR)
  GPL = (CVM, TJF)
  XTB = (CFK, LVG)
  DLJ = (QMS, QRD)
  DDC = (MGN, CFS)
  CGV = (NMB, SND)
  PTK = (HHG, NMR)
  PVX = (LQF, LQF)
  LSG = (RPB, MTQ)
  GCX = (SVS, BGB)
  SSJ = (FRD, TQK)
  VHS = (FTG, FFT)
  VBT = (FSB, SRG)
  HXR = (HDP, MGP)
  JSD = (DGR, FSC)
  HLT = (FHR, PGS)
  TDK = (VQJ, VVC)
  LBR = (VSC, PTD)
  MJL = (GRQ, NHT)
  KMS = (SKC, SKC)
  LXS = (NGM, MNF)
  QVG = (XKN, RTK)
  TSD = (SGH, KPC)
  RBB = (QBG, KDQ)
  FDL = (BVM, BVM)
  XPX = (DLP, QPX)
  HDP = (RKS, THC)
  PJP = (QJK, CQX)
  XCF = (DDB, KML)
  SDK = (KQS, CSP)
  XBH = (NNQ, VFD)
  LSF = (SKL, LKG)
  KBB = (LLJ, LBL)
  VXS = (KFG, LCP)
  GGJ = (PVM, CTR)
  LPH = (SFQ, KMQ)
  PSR = (LPL, XMN)
  TGS = (RJF, JKJ)
  NGX = (XQL, HBL)
  SPF = (BKL, TLD)
  FMH = (GQR, SSS)
  FJQ = (LKX, SHN)
  VNC = (PSR, FMS)
  JRH = (PDC, BHB)
  RTK = (DCR, SSG)
  MPV = (FBV, BMD)
  FQG = (RTN, XKK)
  DGK = (TGM, LGR)
  FFT = (MPV, NDK)
  NRG = (SKK, HLQ)
  LGH = (QQS, LVD)
  QGX = (JGH, BLX)
  FBF = (SKF, JGX)
  MJJ = (LTQ, PTX)
  CSK = (MPB, NRJ)
  VQK = (VHS, TPD)
  DVS = (FJG, MVH)
  PFX = (SCM, RBL)
  SQJ = (LKS, QVN)
  JHH = (JLK, KBS)
  NTL = (GLN, HBK)
  HQS = (VVV, PKG)
  JMR = (NDL, CMJ)
  XNM = (HJD, FCP)
  HDC = (HDL, SPK)
  RXQ = (MRL, LBK)
  BNH = (SFQ, KMQ)
  DGR = (TMM, TTT)
  RXH = (HLQ, SKK)
  FFC = (PPD, VNC)
  LFX = (PKR, LSB)
  XFN = (MVX, CJP)
  NDF = (XSK, TKJ)
  XKN = (SSG, DCR)
  SPK = (VDM, LSF)
  TQF = (BVR, VRK)
  MVK = (TQH, MQS)
  QTN = (FDF, FDF)
  TFG = (NTK, MBB)
  GRQ = (VBL, SBR)
  NVV = (DPH, PXG)
  MNF = (JRH, KCC)
  NHC = (RFH, VXS)
  LSR = (VCR, GCX)
  NDX = (XJM, RGQ)
  TKL = (BSP, BSP)
  KXJ = (VTF, QMC)
  XDV = (NNT, RSN)
  VFG = (JGH, BLX)
  FQP = (SKT, RQP)
  KNM = (KHP, CXK)
  PSL = (QTN, MRG)
  XHG = (FKD, MQB)
  FTS = (SJT, CFC)
  BKL = (HGM, FCQ)
  VHJ = (KPQ, JRB)
  GST = (JHH, KMT)
  VXM = (VVL, SKS)
  KDT = (DPS, CLC)
  NMP = (KDP, RXN)
  CFC = (TXR, MNP)
  DMS = (BGL, DNM)
  LPX = (FML, DNH)
  CGN = (MFH, MVK)
  PSS = (FMH, ZZZ)
  LBJ = (VRL, SDK)
  JJQ = (FSC, DGR)
  NRJ = (DTD, DFT)
  JRK = (XRF, XGV)
  VRK = (KFR, NBQ)
  CQX = (RVJ, SQJ)
  FJM = (RRN, SLJ)
  RGQ = (XRH, VGB)
  FVB = (LXS, LXR)
  BPQ = (CMM, LJF)
  GLT = (FSL, FQP)
  VRL = (CSP, KQS)
  GJC = (HQD, MJL)
  VBL = (XQH, KXL)
  JBV = (NHL, QQM)
  RVL = (CXG, VKP)
  QGG = (KQK, VMT)
  HKH = (MMV, JFN)
  XKK = (CTC, NQN)
  FBH = (QMH, TCH)
  CJL = (TSB, LBX)
  JFS = (BBS, RFN)
  VLS = (XXB, PKD)
  BVJ = (KDF, MRD)
  CMM = (CXQ, BDD)
  PSH = (VXS, RFH)
  VGF = (HTD, QNT)
  LKT = (TKQ, MSR)
  VTB = (HMM, JDJ)
  SVM = (GRJ, MVT)
  KCL = (JTQ, XKM)
  TKT = (TTM, SHB)
  PCB = (XRJ, LTL)
  PJS = (VVL, SKS)
  JHF = (SPD, GKK)
  GBN = (XCF, SLP)
  RTN = (CTC, NQN)
  PSN = (KQF, XFN)
  DLP = (HMK, XMG)
  HCM = (FXM, GGJ)
  BLP = (XHR, NFL)
  LQR = (MLN, DDH)
  CXL = (GMS, HCM)
  JSG = (PVX, SXQ)
  BHM = (PFX, TJD)
  KFT = (XNM, LFL)
  TLP = (RRH, NGX)
  CJP = (FPF, VQK)
  BVR = (KFR, NBQ)
  JTJ = (RXN, KDP)
  KPJ = (HPP, VPV)
  SKS = (TGD, BVJ)
  QVP = (SHL, TKT)
  LCB = (VCR, GCX)
  JTG = (HNX, VBT)
  XHR = (BDV, HHN)
  LFG = (FVB, NQT)
  KRR = (BDT, CTG)
  SFQ = (JSK, CRL)
  CXG = (QXL, MTX)
  PHB = (SLJ, RRN)
  FXD = (LLF, GJM)
  XRF = (JPX, JPX)
  JKD = (LFX, BRQ)
  DJP = (RFN, BBS)
  HMK = (DPK, MKX)
  GKK = (BHJ, GMB)
  FGR = (KFX, HVN)
  RLX = (FKG, GHL)
  TPD = (FFT, FTG)
  NGK = (GBQ, TGB)
  TVM = (HKP, NCT)
  HTB = (DLG, DRM)
  BHQ = (LFL, XNM)
  BLX = (VBS, LPX)
  HNC = (RXR, XSQ)
  SLZ = (TPJ, BBQ)
  GLL = (CDH, BPQ)
  LJF = (BDD, CXQ)
  VRF = (DVX, CTX)
  HQD = (GRQ, NHT)
  QBV = (NMV, TJS)
  MRD = (QSN, CSK)
  MQB = (LBJ, LGK)
  QMG = (FMF, GQJ)
  XJM = (VGB, XRH)
  TLD = (HGM, FCQ)
  VVV = (FGR, GDB)
  FMZ = (MTC, JDQ)
  PCS = (CNK, GKJ)
  FPF = (VHS, TPD)
  XNP = (BKL, TLD)
  BMD = (LFN, XGX)
  CPM = (VVC, VQJ)
  MNP = (JFR, TGS)
  AAA = (GQR, SSS)
  PQX = (NSN, QVP)
  BVB = (TKL, NHR)
  LMH = (SKP, JMK)
  KTB = (SPK, HDL)
  DFT = (RXH, NRG)
  JSK = (FFC, VXD)
  QBG = (SXC, CRC)
  JDJ = (QBV, JGS)
  NNT = (PMC, QNN)
  HLQ = (RBB, QGR)
  MTX = (CJC, HPQ)
  RGF = (TQV, PMV)
  FHR = (PQX, HMR)
  LBX = (BND, RVQ)
  KDC = (NNM, RCH)
  TGM = (KRJ, LSL)
  JFJ = (JPB, DDC)
  HMR = (QVP, NSN)
  NTS = (DQV, DQV)
  PVM = (PDH, KBB)
  LGK = (VRL, SDK)
  TPR = (HKH, RLP)
  GNB = (RSN, NNT)
  FMF = (DJP, JFS)
  LFL = (HJD, FCP)
  SLJ = (MDM, SJP)
  FKR = (HQQ, XXH)
  XXH = (PVP, GJC)
  DMK = (FCF, RXQ)
  HHP = (BVM, PSS)
  MHP = (XBH, SSX)
  MDM = (NTL, GMK)
  DDH = (FTV, NDF)
  LGR = (KRJ, LSL)
  RXR = (CKJ, GSX)
  CDP = (NGX, RRH)
  NBB = (NHC, PSH)
  FSB = (XLG, GJF)
  TJB = (SPD, GKK)
  LKX = (TLN, HTB)
  PCX = (VTF, QMC)
  HQP = (LMP, XXF)
  MJT = (NTK, MBB)
  TQT = (TMP, SLQ)
  HRN = (SKC, FMZ)
  TKQ = (XNP, SPF)
  MRL = (JCT, PCB)
  LTQ = (QCT, DJV)
  GQB = (JJQ, JSD)
  PXG = (SSB, DVS)
  BDP = (CNK, GKJ)
  XJS = (JMJ, QCX)
  PCP = (DSN, NKD)
  VRQ = (DGK, SML)
  LTL = (DQQ, PGF)
  VKS = (JMK, SKP)
  QRF = (JMJ, QCX)
  DCA = (JDQ, MTC)
  QCT = (FCN, GBN)
  VBS = (DNH, FML)
  SGH = (LMH, VKS)
  NDK = (FBV, BMD)
  JFR = (JKJ, RJF)
  VMX = (JSD, JJQ)
  QBM = (DFP, VBM)
  QSN = (NRJ, MPB)
  XRH = (JBV, FHT)
  KDF = (QSN, CSK)
  VDM = (LKG, SKL)
  TNZ = (RMJ, MRC)
  KRJ = (GKS, JFJ)
  VJC = (LVD, QQS)
  JDV = (MTQ, RPB)
  LRM = (HXH, PJP)
  FRD = (VHC, KMN)
  PKG = (FGR, GDB)
  XFR = (LMS, PJX)
  LBK = (PCB, JCT)
  SDD = (CFF, FRJ)
  BKQ = (RJD, TVM)
  NDL = (GNB, XDV)
  KMF = (MQQ, KNM)
  TPT = (KMS, HRN)
  NMB = (HTX, PCP)
  SML = (LGR, TGM)
  CRC = (TQT, XPD)
  HRR = (NBV, JMR)
  KMQ = (JSK, CRL)
  VCR = (SVS, BGB)
  NRR = (RMK, XVF)
  PPS = (TKL, NHR)
  CXK = (PCX, KXJ)
  FBB = (FKG, GHL)
  JKJ = (BTM, KCL)
  CQL = (BMQ, HLF)
  CTX = (MJJ, CKP)
  RLP = (JFN, MMV)
  HMD = (NHC, PSH)
  JDG = (CLJ, TDN)
  HTD = (PNJ, PNJ)
  CFS = (NVV, RRK)
  KPC = (LMH, VKS)
  TCH = (JFL, GGD)
  GBQ = (FBH, TDS)
  PCL = (DMS, JSR)
  LTD = (GQJ, FMF)
  LGA = (BBQ, TPJ)
  TMP = (KDV, JKD)
  QGR = (QBG, KDQ)
  MRG = (FDF, SLZ)
  CRL = (FFC, VXD)
  VQF = (SSX, XBH)
  CKJ = (FVC, TSD)
  CSP = (LGH, VJC)
  RQN = (XFS, FQG)
  TDS = (TCH, QMH)
  CKP = (PTX, LTQ)
  BGB = (RFX, FDK)
  PPJ = (BLP, TXG)
  JFT = (FRT, TXD)
  QNT = (PNJ, TPT)
  XQH = (MVL, FKQ)
  DRM = (TCS, KKM)
  HBL = (DDQ, BTN)
  RMJ = (MJH, DLJ)
  PXV = (KQK, VMT)
  SLP = (DDB, KML)
  GBF = (MQB, FKD)
  FVG = (JRB, KPQ)
  DDQ = (JPR, FJD)
  CFQ = (FBF, GCN)
  QQM = (KLX, XKB)
  CFK = (XHG, GBF)
  VVC = (VFG, QGX)
  PGF = (LPF, VLS)
  KLX = (NXQ, QJH)
  QGP = (FHR, PGS)
  FLP = (HTD, QNT)
  NLA = (PRD, LFG)
  HKP = (TCC, XKG)
  KHB = (TFR, QVG)
  VBM = (NPV, PSP)
  FCX = (NNM, RCH)
  MTC = (QCH, TPR)
  FQS = (CFK, LVG)
  FML = (HLT, QGP)
  PRD = (FVB, NQT)
  DHD = (QXM, LQR)
  HVR = (VBM, DFP)
  XMG = (MKX, DPK)
  SPD = (BHJ, GMB)
  MVL = (DDP, XFR)
  BSP = (QTN, QTN)
  PTD = (XTB, FQS)
  QMS = (HRR, PGV)
  SSS = (VRF, SFT)
  GKQ = (NHK, DMZ)
  SSB = (FJG, MVH)
  DPK = (LCB, LSR)
  JFL = (HNC, GPT)
  DNM = (JQR, MNV)
  NHK = (RMR, LKT)
  KMN = (LXP, RVL)
  GLH = (DQV, JSG)
  KPQ = (HQS, DKM)
  DJV = (GBN, FCN)
  XXF = (RGD, FRV)
  NCT = (XKG, TCC)
  FRQ = (GLT, MXS)
  DSN = (JQX, HXR)
  NBV = (CMJ, NDL)
  TLN = (DLG, DRM)
  FCP = (FJM, PHB)
  SHN = (TLN, HTB)
  GKJ = (PJF, QRL)
  TKG = (SJT, CFC)
  QJK = (RVJ, SQJ)
  JQX = (HDP, MGP)
  HXC = (VMX, GQB)
  LLF = (QPQ, RQN)
  TXD = (BCK, XPX)
  RGD = (BBT, BBT)
  MPB = (DFT, DTD)
  LXR = (NGM, MNF)
  FCQ = (KMF, JJS)
  PQQ = (LQG, PSN)
  TQK = (KMN, VHC)
  CVM = (NGK, TXF)
  NNQ = (FRQ, LJV)
  PJX = (TLP, CDP)
  TTM = (JNM, DHD)
  JPR = (VGF, FLP)
  BDV = (HFV, FGD)
  PMV = (GLL, DHP)
  NBQ = (FLX, JRK)
  BGL = (MNV, JQR)
  PDH = (LBL, LLJ)
  SLQ = (KDV, JKD)
  NMV = (BKQ, RKM)
  KFF = (FTS, TKG)
  XFS = (RTN, XKK)
  RJD = (NCT, HKP)
  DDB = (SVM, RCL)
  MMV = (HSF, PCL)
  JDQ = (TPR, QCH)
  NHT = (SBR, VBL)
  CFF = (MXL, MGT)
  KXL = (FKQ, MVL)
  GLD = (PJS, VXM)
  DXL = (XVF, RMK)
  MXS = (FSL, FQP)
  HGM = (KMF, JJS)
  PMC = (VLH, FXD)
  QCH = (RLP, HKH)
  SHL = (SHB, TTM)
  FSC = (TTT, TMM)
  QMH = (JFL, GGD)
  FKG = (NRR, DXL)
  SKP = (PHK, BHX)
  QXL = (HPQ, CJC)
  HBX = (FBF, GCN)
  VGB = (JBV, FHT)
  VLH = (LLF, GJM)
  MFH = (TQH, MQS)
  RNC = (SHN, LKX)
  SJT = (TXR, MNP)
  LKS = (RKJ, BGH)
  SXQ = (LQF, TNZ)
  RLK = (DGK, SML)
  RRN = (SJP, MDM)
  XGV = (JPX, VNZ)
  SMR = (RLX, FBB)
  JMJ = (BNT, LRM)
  BRQ = (PKR, LSB)
  JRB = (DKM, HQS)
  QRL = (CQL, MVB)
  MQS = (NJP, KHB)
  PGS = (HMR, PQX)
  RFN = (KDC, FCX)
  GPP = (GQB, VMX)
  JSR = (BGL, DNM)
  KKM = (BMC, JSV)
  JMK = (BHX, PHK)
  VFD = (FRQ, LJV)
  BVM = (FMH, FMH)
  BHX = (MJT, TFG)
  CJC = (LSG, JDV)
  SSG = (MNJ, GST)
  HNX = (FSB, SRG)
  KFG = (PQQ, HJK)
  BTM = (JTQ, XKM)
  FTV = (XSK, TKJ)
  SRG = (XLG, GJF)
  FMS = (XMN, LPL)
  FVK = (XJD, GLD)
  SCF = (GPL, BFF)
  FDK = (QRF, XJS)
  RVQ = (VHV, SMR)
  CBC = (RPN, MPN)
  RBL = (RNC, FJQ)
  VNZ = (LFG, PRD)
  KFR = (FLX, FLX)
  BTN = (JPR, FJD)
  VPA = (RMR, LKT)
  BNT = (HXH, PJP)
  SJP = (GMK, NTL)
  VVL = (BVJ, TGD)
  MRC = (MJH, DLJ)
  NMR = (PDL, JFT)
  GLN = (HKX, CBC)
  LPF = (XXB, PKD)
  GQJ = (DJP, JFS)
  GRJ = (JHF, TJB)
  LFN = (FDL, FDL)
  XKM = (CGV, JNC)
  RMK = (KFF, VQD)
  VDC = (DPS, CLC)
  PSP = (KTB, HDC)
  GJG = (FQM, TQM)
  XMN = (JJP, HQP)
  GCN = (JGX, SKF)
  CHG = (KPJ, HRG)
  KDP = (PPS, BVB)
  GMK = (GLN, HBK)
  BND = (VHV, SMR)
  XXB = (VHJ, FVG)
  VHV = (FBB, RLX)
  PNJ = (KMS, KMS)
  SND = (PCP, HTX)
  QVN = (RKJ, BGH)
  QHP = (HMD, NBB)
  CTC = (HXC, GPP)
  CTB = (LBX, TSB)
  CLC = (QFL, JDG)
  KQS = (VJC, LGH)
  PKD = (VHJ, FVG)
  TDN = (KRR, NXP)
  SNH = (RLK, VRQ)
  GQR = (SFT, VRF)
  FKQ = (DDP, XFR)
  XSQ = (GSX, CKJ)
  BHB = (CHG, PNM)
  SBR = (KXL, XQH)
  CKC = (HQQ, XXH)
  GDB = (KFX, HVN)
  GMB = (SDD, HCP)
  MTQ = (CGN, PFT)
  GPT = (XSQ, RXR)
  LCP = (HJK, PQQ)
  LPL = (JJP, HQP)
  MLN = (FTV, NDF)
  BMQ = (QMG, LTD)
  FRJ = (MGT, MXL)
  HQQ = (GJC, PVP)
  JNM = (LQR, QXM)
  TKJ = (BDP, PCS)
  SKF = (HBM, CXL)
  NNM = (RGF, PRB)
  MNV = (CPM, TDK)
  CXQ = (QCR, QFP)
  MGP = (THC, RKS)
  HLF = (QMG, LTD)
  TQM = (SNH, MSD)
  MVX = (VQK, FPF)
  JPB = (CFS, MGN)
  NJP = (TFR, QVG)
  TXF = (GBQ, TGB)
  BBT = (NHK, NHK)
  LSL = (GKS, JFJ)
  HGL = (VDC, KDT)
  THC = (SCF, KFJ)
  TXR = (TGS, JFR)
  XJD = (VXM, PJS)
  QPX = (XMG, HMK)
  LSB = (HHR, QHP)
  SSX = (NNQ, VFD)
  CNK = (PJF, QRL)
  SXC = (XPD, TQT)
  JGH = (LPX, VBS)
  QNN = (FXD, VLH)
  XPD = (SLQ, TMP)
  NGM = (KCC, JRH)
  XLG = (MHP, VQF)
  PKR = (HHR, QHP)
  MNJ = (KMT, JHH)
  FLX = (XRF, XRF)
  FQM = (MSD, SNH)
  MXL = (HGL, SRC)
  MJH = (QRD, QMS)
  DTD = (NRG, RXH)
  VSC = (XTB, FQS)
  FXM = (CTR, PVM)
  MGN = (RRK, NVV)
  RCH = (PRB, RGF)
  QXM = (DDH, MLN)
  HKX = (RPN, MPN)
  LQG = (XFN, KQF)
  KQF = (MVX, CJP)
  VPV = (BHM, PDV)
  VXD = (VNC, PPD)
  ZZZ = (SSS, GQR)
  QCX = (BNT, LRM)
  TSB = (BND, RVQ)
  LJV = (GLT, MXS)
  XQL = (BTN, DDQ)
  XRJ = (DQQ, PGF)
  MQQ = (KHP, CXK)
  NTR = (PTK, TBH)
  TCS = (JSV, BMC)
  MGT = (SRC, HGL)
  TXG = (XHR, NFL)
  JGX = (CXL, HBM)
  DNF = (BVR, VRK)
  SRC = (VDC, KDT)
  RJF = (BTM, KCL)
  NPV = (KTB, HDC)
  QJH = (CKN, SSJ)
  FRV = (BBT, GKQ)
  QPQ = (XFS, FQG)
  BDT = (DFR, FVK)
  RQP = (CJL, CTB)
  JRX = (BLP, TXG)
  GHL = (DXL, NRR)
  TGD = (MRD, KDF)
  HXH = (CQX, QJK)";

      long expected = 0;
      long actual = code.Processor2.Process(input);
      Assert.AreEqual(expected, actual);
    }
}
