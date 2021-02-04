//Maya ASCII 2017ff05 scene
//Name: enburu.ma
//Last modified: Tue, Apr 10, 2018 11:30:36 AM
//Codeset: 932
requires maya "2017ff05";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2017";
fileInfo "version" "2017";
fileInfo "cutIdentifier" "201710312130-1018716";
fileInfo "osv" "Microsoft Windows 8 Home Premium Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -n "pCylinder1";
	rename -uid "DF4F81F8-461B-0178-09B4-478E0D41F9B9";
	setAttr ".s" -type "double3" 8.6271910208017619 16.093561752794923 2.1699958808673667 ;
createNode mesh -n "pCylinderShape1" -p "pCylinder1";
	rename -uid "904DBEC5-4C79-325C-3B67-CEB4058E43E5";
	setAttr -k off ".v";
	setAttr -s 4 ".iog[0].og";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.49999994039535522 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
createNode groupId -n "groupId1";
	rename -uid "23F21FF2-4914-EA09-CADC-FE9F2586E92F";
	setAttr ".ihi" 0;
createNode groupId -n "groupId3";
	rename -uid "A21B2CF7-44FA-4976-D1F5-7FBB65D47E7B";
	setAttr ".ihi" 0;
createNode shadingEngine -n "blinn1SG";
	rename -uid "94597C64-4BF2-3AB2-AA56-3E9F4D13062F";
	setAttr ".ihi" 0;
	setAttr ".ro" yes;
createNode materialInfo -n "materialInfo1";
	rename -uid "5E0CE3A2-45F9-7674-18FC-23BA83EC9D00";
createNode blinn -n "ennbill";
	rename -uid "A891396D-4025-C142-BA94-5E9A5814C90D";
createNode file -n "file1";
	rename -uid "A777DB76-4959-3E47-3C1D-B9BBDEE1F88B";
	setAttr ".ftn" -type "string" "C:/Users/FMV/Documents/KIES/kumonosu/birumado5.jpg";
	setAttr ".cs" -type "string" "sRGB";
createNode place2dTexture -n "place2dTexture1";
	rename -uid "D6B34B87-46FB-BB08-C6C3-0780B77438D0";
createNode polyPlanarProj -n "polyPlanarProj3";
	rename -uid "DEDBD1EA-4CA0-9629-A468-4CBCBDA96C51";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[0:8]";
	setAttr ".ix" -type "matrix" 8.6271910208017619 0 0 0 0 16.093561752794923 0 0 0 0 2.1699958808673667 0
		 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pc" -type "double3" -0.21112060546875 0 -1.0849981307983398 ;
	setAttr ".ps" -type "double2" 16.832143783569336 32.187122344970703 ;
	setAttr ".cam" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
createNode polyPlanarProj -n "polyPlanarProj2";
	rename -uid "34A332BD-4EE4-64CE-0CEB-18B8DA55537D";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[9:18]";
	setAttr ".ix" -type "matrix" 8.6271910208017619 0 0 0 0 16.093561752794923 0 0 0 0 2.1699958808673667 0
		 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pc" -type "double3" -9.5367431640625e-007 0 1.0849978923797607 ;
	setAttr ".ps" -type "double2" 17.254383087158203 32.187122344970703 ;
	setAttr ".cam" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
createNode polyPlanarProj -n "polyPlanarProj1";
	rename -uid "98A4A2E8-4162-B712-E3F0-05AF0A270D41";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 1 "f[9:18]";
	setAttr ".ix" -type "matrix" 8.6271910208017619 0 0 0 0 16.093561752794923 0 0 0 0 2.1699958808673667 0
		 0 0 0 1;
	setAttr ".ws" yes;
	setAttr ".pc" -type "double3" -9.5367431640625e-007 0 1.0849980115890503 ;
	setAttr ".ro" -type "double3" 0 90 0 ;
	setAttr ".ps" -type "double2" 2.1699960231781006 32.187122344970703 ;
	setAttr ".cam" -type "matrix" 1 0 0 0 0 1 0 0 0 0 1 0 0 0 0 1;
createNode polyTweakUV -n "polyTweakUV1";
	rename -uid "FEEFE65E-4BC2-30AE-94E6-C6A85222A028";
	setAttr ".uopa" yes;
	setAttr -s 84 ".uvtk[0:83]" -type "float2" -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784
		 0 -1.023418784 0 -1.023418784 0 -1.023418784 0 -1.023418784 0;
createNode groupParts -n "groupParts2";
	rename -uid "D190CA01-491A-EAC8-5293-74AC9349448F";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "f[0:18]";
createNode groupParts -n "groupParts1";
	rename -uid "65FF4955-40A3-4829-2052-85A418E634DD";
	setAttr ".ihi" 0;
	setAttr ".ic" -type "componentList" 1 "f[19:59]";
	setAttr ".irc" -type "componentList" 1 "f[0:18]";
createNode polyCylinder -n "polyCylinder1";
	rename -uid "E1F19760-4A45-40BE-3687-3488FA130541";
	setAttr ".sc" 1;
	setAttr ".cuv" 3;
createNode groupId -n "groupId2";
	rename -uid "523EAB22-43CB-46E7-25C3-538153B03E16";
	setAttr ".ihi" 0;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "45D424AF-442E-4B50-C8F3-22AF4113104C";
	setAttr -s 3 ".lnk";
	setAttr -s 3 ".slnk";
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 3 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 5 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderUtilityList1;
select -ne :defaultRenderingList1;
select -ne :defaultTextureList1;
select -ne :initialShadingGroup;
	setAttr -s 2 ".dsm";
	setAttr ".ro" yes;
	setAttr -s 2 ".gn";
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "groupId1.id" "pCylinderShape1.iog.og[0].gid";
connectAttr ":initialShadingGroup.mwc" "pCylinderShape1.iog.og[0].gco";
connectAttr "groupId3.id" "pCylinderShape1.iog.og[1].gid";
connectAttr "blinn1SG.mwc" "pCylinderShape1.iog.og[1].gco";
connectAttr "polyPlanarProj3.out" "pCylinderShape1.i";
connectAttr "groupId2.id" "pCylinderShape1.ciog.cog[0].cgid";
connectAttr "polyTweakUV1.uvtk[0]" "pCylinderShape1.uvst[0].uvtw";
connectAttr "ennbill.oc" "blinn1SG.ss";
connectAttr "groupId3.msg" "blinn1SG.gn" -na;
connectAttr "pCylinderShape1.iog.og[1]" "blinn1SG.dsm" -na;
connectAttr "blinn1SG.msg" "materialInfo1.sg";
connectAttr "ennbill.msg" "materialInfo1.m";
connectAttr "file1.msg" "materialInfo1.t" -na;
connectAttr "file1.oc" "ennbill.c";
connectAttr ":defaultColorMgtGlobals.cme" "file1.cme";
connectAttr ":defaultColorMgtGlobals.cfe" "file1.cmcf";
connectAttr ":defaultColorMgtGlobals.cfp" "file1.cmcp";
connectAttr ":defaultColorMgtGlobals.wsn" "file1.ws";
connectAttr "place2dTexture1.c" "file1.c";
connectAttr "place2dTexture1.tf" "file1.tf";
connectAttr "place2dTexture1.rf" "file1.rf";
connectAttr "place2dTexture1.mu" "file1.mu";
connectAttr "place2dTexture1.mv" "file1.mv";
connectAttr "place2dTexture1.s" "file1.s";
connectAttr "place2dTexture1.wu" "file1.wu";
connectAttr "place2dTexture1.wv" "file1.wv";
connectAttr "place2dTexture1.re" "file1.re";
connectAttr "place2dTexture1.of" "file1.of";
connectAttr "place2dTexture1.r" "file1.ro";
connectAttr "place2dTexture1.n" "file1.n";
connectAttr "place2dTexture1.vt1" "file1.vt1";
connectAttr "place2dTexture1.vt2" "file1.vt2";
connectAttr "place2dTexture1.vt3" "file1.vt3";
connectAttr "place2dTexture1.vc1" "file1.vc1";
connectAttr "place2dTexture1.o" "file1.uv";
connectAttr "place2dTexture1.ofs" "file1.fs";
connectAttr "polyPlanarProj2.out" "polyPlanarProj3.ip";
connectAttr "pCylinderShape1.wm" "polyPlanarProj3.mp";
connectAttr "polyPlanarProj1.out" "polyPlanarProj2.ip";
connectAttr "pCylinderShape1.wm" "polyPlanarProj2.mp";
connectAttr "polyTweakUV1.out" "polyPlanarProj1.ip";
connectAttr "pCylinderShape1.wm" "polyPlanarProj1.mp";
connectAttr "groupParts2.og" "polyTweakUV1.ip";
connectAttr "groupParts1.og" "groupParts2.ig";
connectAttr "groupId3.id" "groupParts2.gi";
connectAttr "polyCylinder1.out" "groupParts1.ig";
connectAttr "groupId1.id" "groupParts1.gi";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" "blinn1SG.message" ":defaultLightSet.message";
connectAttr "blinn1SG.pa" ":renderPartition.st" -na;
connectAttr "ennbill.msg" ":defaultShaderList1.s" -na;
connectAttr "place2dTexture1.msg" ":defaultRenderUtilityList1.u" -na;
connectAttr "file1.msg" ":defaultTextureList1.tx" -na;
connectAttr "pCylinderShape1.iog.og[0]" ":initialShadingGroup.dsm" -na;
connectAttr "pCylinderShape1.ciog.cog[0]" ":initialShadingGroup.dsm" -na;
connectAttr "groupId1.msg" ":initialShadingGroup.gn" -na;
connectAttr "groupId2.msg" ":initialShadingGroup.gn" -na;
// End of enburu.ma
