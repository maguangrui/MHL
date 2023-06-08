--- <auto-generated>
---     Generated by the moonfly tool.  DO NOT EDIT!
--- </auto-generated>

local M={
    C2SMatch = 1,
    S2CMatch = 2,
    S2CMatchSuccess = 3,
    S2CGameOver = 4,
    C2SEnterRoom = 5,
    S2CEnterRoom = 6,
    C2SMove = 7,
    S2CMove = 8,
    S2CEnterView = 9,
    S2CLeaveView = 10,
    S2CUpdateRadius = 11,
    S2CDead = 12,
    S2CErrorCode = 13,
    C2SLogin = 14,
    S2CLogin = 15,
    C2SItemList = 16,
    S2CItemList = 17,
    C2SUseItem = 18,
    S2CUpdateItem = 19,
    C2SHello = 20,
    S2CWorld = 21,

}

local forward = {
    C2SMatch = 'addr_center',
    C2SEnterRoom = 'addr_room',
    C2SMove = 'addr_room',
    C2SLogin = 'addr_user',
    C2SItemList = 'addr_user',
    C2SUseItem = 'addr_user',
    C2SHello = 'addr_user',

}

local mt = { forward = forward }

mt.__newindex = function(_, name, _)
    local msg = "attemp index unknown message: " .. tostring(name)
    error(debug.traceback(msg, 2))
end

mt.__index = function(_, name)
    if name == "forward" then
        return forward
    end
    local msg = "attemp index unknown message: " .. tostring(name)
    error(debug.traceback(msg, 2))
end

return setmetatable(M,mt)