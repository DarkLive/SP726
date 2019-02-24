CREATE VIEW ShowComputers AS
SELECT Computer.comID, CPU.cpuName, OperatingSystem.osName, Computer.ramSize, Computer.diskSize, Computer.ssdSize, Computer.price FROM Computer
INNER JOIN CPU ON Computer.cpuBrandID = cpuID
INNER JOIN OperatingSystem ON Computer.opeSysID = OperatingSystem.osID