ITEM = {{}}

ITEM.ClassName = "testname"
ITEM.Name = "TestName"
ITEM.Description = "TestDesc"
ITEM.Model = "TestMDL"

ITEM.PointsCost = 2500
ITEM.PremiumPointsCost = 0

ITEM.AddToInventory = true
ITEM.FocusPart = ""
ITEM.Adjustable = true

ITEM.WElements = { 
	["Jet Backbling"] = { type = "Model", model = "models/xqm/jetbody3.mdl", bone = "ValveBiped.Bip01_Spine2", rel = "", pos = Vector(-5.715, 2.596, 0), angle = Angle(90, -180, -90), size = Vector(0.23, 0.23, 0.23), color = Color(255, 255, 255, 255), surpresslightning = false, material = "", skin = 0, bodygroup = {} }
}
ITEM.PACData = nil

SH_POINTSHOP:RegisterItem(ITEM, "accessories")
