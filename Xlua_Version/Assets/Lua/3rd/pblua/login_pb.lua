-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf/protobuf"
module('Login_pb')


local REGISTERRESULT = protobuf.EnumDescriptor();
local REGISTERRESULT_HAS_USER_ENUM = protobuf.EnumValueDescriptor();
local REGISTERRESULT_ILLEGAL_ENUM = protobuf.EnumValueDescriptor();
local REGISTERRESULT_REGISTER_SUCCESS_ENUM = protobuf.EnumValueDescriptor();
local LANDRESULT = protobuf.EnumDescriptor();
local LANDRESULT_NO_USER_ENUM = protobuf.EnumValueDescriptor();
local LANDRESULT_NO_PASSWORD_ENUM = protobuf.EnumValueDescriptor();
local LANDRESULT_LAND_SUCCESS_ENUM = protobuf.EnumValueDescriptor();
local REGISTERREQUEST = protobuf.Descriptor();
local REGISTERREQUEST_NAME_FIELD = protobuf.FieldDescriptor();
local REGISTERREQUEST_PASSWORD_FIELD = protobuf.FieldDescriptor();
local REGISTERRESPONSE = protobuf.Descriptor();
local REGISTERRESPONSE_RESULT_FIELD = protobuf.FieldDescriptor();
local LOGINREQUEST = protobuf.Descriptor();
local LOGINREQUEST_NAME_FIELD = protobuf.FieldDescriptor();
local LOGINREQUEST_PASSWORD_FIELD = protobuf.FieldDescriptor();
local LOGINRESPONSE = protobuf.Descriptor();
local LOGINRESPONSE_RESULT_FIELD = protobuf.FieldDescriptor();
local LOGINRESPONSE_ROLDID_FIELD = protobuf.FieldDescriptor();
local CREATEROLEREQUEST = protobuf.Descriptor();
local CREATEROLEREQUEST_ROLENAME_FIELD = protobuf.FieldDescriptor();
local CREATEROLERESPONSE = protobuf.Descriptor();
local CREATEROLERESPONSE_ROLEID_FIELD = protobuf.FieldDescriptor();
local ROLER = protobuf.Descriptor();
local ROLER_ROLERID_FIELD = protobuf.FieldDescriptor();
local ROLER_ENERGY_FIELD = protobuf.FieldDescriptor();
local ROLER_GOLD_FIELD = protobuf.FieldDescriptor();
local ROLELOGINREQUEST = protobuf.Descriptor();
local ROLELOGINREQUEST_ROLEID_FIELD = protobuf.FieldDescriptor();
local ROLELOGINRESPONSE = protobuf.Descriptor();
local ROLELOGINRESPONSE_ROLE_FIELD = protobuf.FieldDescriptor();

REGISTERRESULT_HAS_USER_ENUM.name = "HAS_USER"
REGISTERRESULT_HAS_USER_ENUM.index = 0
REGISTERRESULT_HAS_USER_ENUM.number = 0
REGISTERRESULT_ILLEGAL_ENUM.name = "ILLEGAL"
REGISTERRESULT_ILLEGAL_ENUM.index = 1
REGISTERRESULT_ILLEGAL_ENUM.number = 1
REGISTERRESULT_REGISTER_SUCCESS_ENUM.name = "REGISTER_SUCCESS"
REGISTERRESULT_REGISTER_SUCCESS_ENUM.index = 2
REGISTERRESULT_REGISTER_SUCCESS_ENUM.number = 2
REGISTERRESULT.name = "RegisterResult"
REGISTERRESULT.full_name = ".RegisterResult"
REGISTERRESULT.values = {REGISTERRESULT_HAS_USER_ENUM,REGISTERRESULT_ILLEGAL_ENUM,REGISTERRESULT_REGISTER_SUCCESS_ENUM}
LANDRESULT_NO_USER_ENUM.name = "NO_USER"
LANDRESULT_NO_USER_ENUM.index = 0
LANDRESULT_NO_USER_ENUM.number = 0
LANDRESULT_NO_PASSWORD_ENUM.name = "NO_PASSWORD"
LANDRESULT_NO_PASSWORD_ENUM.index = 1
LANDRESULT_NO_PASSWORD_ENUM.number = 1
LANDRESULT_LAND_SUCCESS_ENUM.name = "LAND_SUCCESS"
LANDRESULT_LAND_SUCCESS_ENUM.index = 2
LANDRESULT_LAND_SUCCESS_ENUM.number = 2
LANDRESULT.name = "LandResult"
LANDRESULT.full_name = ".LandResult"
LANDRESULT.values = {LANDRESULT_NO_USER_ENUM,LANDRESULT_NO_PASSWORD_ENUM,LANDRESULT_LAND_SUCCESS_ENUM}
REGISTERREQUEST_NAME_FIELD.name = "name"
REGISTERREQUEST_NAME_FIELD.full_name = ".RegisterRequest.name"
REGISTERREQUEST_NAME_FIELD.number = 1
REGISTERREQUEST_NAME_FIELD.index = 0
REGISTERREQUEST_NAME_FIELD.label = 2
REGISTERREQUEST_NAME_FIELD.has_default_value = false
REGISTERREQUEST_NAME_FIELD.default_value = ""
REGISTERREQUEST_NAME_FIELD.type = 9
REGISTERREQUEST_NAME_FIELD.cpp_type = 9

REGISTERREQUEST_PASSWORD_FIELD.name = "password"
REGISTERREQUEST_PASSWORD_FIELD.full_name = ".RegisterRequest.password"
REGISTERREQUEST_PASSWORD_FIELD.number = 2
REGISTERREQUEST_PASSWORD_FIELD.index = 1
REGISTERREQUEST_PASSWORD_FIELD.label = 2
REGISTERREQUEST_PASSWORD_FIELD.has_default_value = false
REGISTERREQUEST_PASSWORD_FIELD.default_value = ""
REGISTERREQUEST_PASSWORD_FIELD.type = 9
REGISTERREQUEST_PASSWORD_FIELD.cpp_type = 9

REGISTERREQUEST.name = "RegisterRequest"
REGISTERREQUEST.full_name = ".RegisterRequest"
REGISTERREQUEST.nested_types = {}
REGISTERREQUEST.enum_types = {}
REGISTERREQUEST.fields = {REGISTERREQUEST_NAME_FIELD, REGISTERREQUEST_PASSWORD_FIELD}
REGISTERREQUEST.is_extendable = false
REGISTERREQUEST.extensions = {}
REGISTERRESPONSE_RESULT_FIELD.name = "result"
REGISTERRESPONSE_RESULT_FIELD.full_name = ".RegisterResponse.result"
REGISTERRESPONSE_RESULT_FIELD.number = 1
REGISTERRESPONSE_RESULT_FIELD.index = 0
REGISTERRESPONSE_RESULT_FIELD.label = 2
REGISTERRESPONSE_RESULT_FIELD.has_default_value = false
REGISTERRESPONSE_RESULT_FIELD.default_value = nil
REGISTERRESPONSE_RESULT_FIELD.enum_type = REGISTERRESULT
REGISTERRESPONSE_RESULT_FIELD.type = 14
REGISTERRESPONSE_RESULT_FIELD.cpp_type = 8

REGISTERRESPONSE.name = "RegisterResponse"
REGISTERRESPONSE.full_name = ".RegisterResponse"
REGISTERRESPONSE.nested_types = {}
REGISTERRESPONSE.enum_types = {}
REGISTERRESPONSE.fields = {REGISTERRESPONSE_RESULT_FIELD}
REGISTERRESPONSE.is_extendable = false
REGISTERRESPONSE.extensions = {}
LOGINREQUEST_NAME_FIELD.name = "name"
LOGINREQUEST_NAME_FIELD.full_name = ".LoginRequest.name"
LOGINREQUEST_NAME_FIELD.number = 1
LOGINREQUEST_NAME_FIELD.index = 0
LOGINREQUEST_NAME_FIELD.label = 2
LOGINREQUEST_NAME_FIELD.has_default_value = false
LOGINREQUEST_NAME_FIELD.default_value = ""
LOGINREQUEST_NAME_FIELD.type = 9
LOGINREQUEST_NAME_FIELD.cpp_type = 9

LOGINREQUEST_PASSWORD_FIELD.name = "password"
LOGINREQUEST_PASSWORD_FIELD.full_name = ".LoginRequest.password"
LOGINREQUEST_PASSWORD_FIELD.number = 2
LOGINREQUEST_PASSWORD_FIELD.index = 1
LOGINREQUEST_PASSWORD_FIELD.label = 2
LOGINREQUEST_PASSWORD_FIELD.has_default_value = false
LOGINREQUEST_PASSWORD_FIELD.default_value = ""
LOGINREQUEST_PASSWORD_FIELD.type = 9
LOGINREQUEST_PASSWORD_FIELD.cpp_type = 9

LOGINREQUEST.name = "LoginRequest"
LOGINREQUEST.full_name = ".LoginRequest"
LOGINREQUEST.nested_types = {}
LOGINREQUEST.enum_types = {}
LOGINREQUEST.fields = {LOGINREQUEST_NAME_FIELD, LOGINREQUEST_PASSWORD_FIELD}
LOGINREQUEST.is_extendable = false
LOGINREQUEST.extensions = {}
LOGINRESPONSE_RESULT_FIELD.name = "result"
LOGINRESPONSE_RESULT_FIELD.full_name = ".LoginResponse.result"
LOGINRESPONSE_RESULT_FIELD.number = 1
LOGINRESPONSE_RESULT_FIELD.index = 0
LOGINRESPONSE_RESULT_FIELD.label = 2
LOGINRESPONSE_RESULT_FIELD.has_default_value = false
LOGINRESPONSE_RESULT_FIELD.default_value = nil
LOGINRESPONSE_RESULT_FIELD.enum_type = LANDRESULT
LOGINRESPONSE_RESULT_FIELD.type = 14
LOGINRESPONSE_RESULT_FIELD.cpp_type = 8

LOGINRESPONSE_ROLDID_FIELD.name = "roldId"
LOGINRESPONSE_ROLDID_FIELD.full_name = ".LoginResponse.roldId"
LOGINRESPONSE_ROLDID_FIELD.number = 2
LOGINRESPONSE_ROLDID_FIELD.index = 1
LOGINRESPONSE_ROLDID_FIELD.label = 2
LOGINRESPONSE_ROLDID_FIELD.has_default_value = false
LOGINRESPONSE_ROLDID_FIELD.default_value = 0
LOGINRESPONSE_ROLDID_FIELD.type = 5
LOGINRESPONSE_ROLDID_FIELD.cpp_type = 1

LOGINRESPONSE.name = "LoginResponse"
LOGINRESPONSE.full_name = ".LoginResponse"
LOGINRESPONSE.nested_types = {}
LOGINRESPONSE.enum_types = {}
LOGINRESPONSE.fields = {LOGINRESPONSE_RESULT_FIELD, LOGINRESPONSE_ROLDID_FIELD}
LOGINRESPONSE.is_extendable = false
LOGINRESPONSE.extensions = {}
CREATEROLEREQUEST_ROLENAME_FIELD.name = "roleName"
CREATEROLEREQUEST_ROLENAME_FIELD.full_name = ".CreateRoleRequest.roleName"
CREATEROLEREQUEST_ROLENAME_FIELD.number = 1
CREATEROLEREQUEST_ROLENAME_FIELD.index = 0
CREATEROLEREQUEST_ROLENAME_FIELD.label = 2
CREATEROLEREQUEST_ROLENAME_FIELD.has_default_value = false
CREATEROLEREQUEST_ROLENAME_FIELD.default_value = ""
CREATEROLEREQUEST_ROLENAME_FIELD.type = 9
CREATEROLEREQUEST_ROLENAME_FIELD.cpp_type = 9

CREATEROLEREQUEST.name = "CreateRoleRequest"
CREATEROLEREQUEST.full_name = ".CreateRoleRequest"
CREATEROLEREQUEST.nested_types = {}
CREATEROLEREQUEST.enum_types = {}
CREATEROLEREQUEST.fields = {CREATEROLEREQUEST_ROLENAME_FIELD}
CREATEROLEREQUEST.is_extendable = false
CREATEROLEREQUEST.extensions = {}
CREATEROLERESPONSE_ROLEID_FIELD.name = "roleId"
CREATEROLERESPONSE_ROLEID_FIELD.full_name = ".CreateRoleResponse.roleId"
CREATEROLERESPONSE_ROLEID_FIELD.number = 1
CREATEROLERESPONSE_ROLEID_FIELD.index = 0
CREATEROLERESPONSE_ROLEID_FIELD.label = 2
CREATEROLERESPONSE_ROLEID_FIELD.has_default_value = false
CREATEROLERESPONSE_ROLEID_FIELD.default_value = 0
CREATEROLERESPONSE_ROLEID_FIELD.type = 5
CREATEROLERESPONSE_ROLEID_FIELD.cpp_type = 1

CREATEROLERESPONSE.name = "CreateRoleResponse"
CREATEROLERESPONSE.full_name = ".CreateRoleResponse"
CREATEROLERESPONSE.nested_types = {}
CREATEROLERESPONSE.enum_types = {}
CREATEROLERESPONSE.fields = {CREATEROLERESPONSE_ROLEID_FIELD}
CREATEROLERESPONSE.is_extendable = false
CREATEROLERESPONSE.extensions = {}
ROLER_ROLERID_FIELD.name = "rolerId"
ROLER_ROLERID_FIELD.full_name = ".Roler.rolerId"
ROLER_ROLERID_FIELD.number = 1
ROLER_ROLERID_FIELD.index = 0
ROLER_ROLERID_FIELD.label = 2
ROLER_ROLERID_FIELD.has_default_value = false
ROLER_ROLERID_FIELD.default_value = 0
ROLER_ROLERID_FIELD.type = 5
ROLER_ROLERID_FIELD.cpp_type = 1

ROLER_ENERGY_FIELD.name = "energy"
ROLER_ENERGY_FIELD.full_name = ".Roler.energy"
ROLER_ENERGY_FIELD.number = 2
ROLER_ENERGY_FIELD.index = 1
ROLER_ENERGY_FIELD.label = 2
ROLER_ENERGY_FIELD.has_default_value = false
ROLER_ENERGY_FIELD.default_value = 0
ROLER_ENERGY_FIELD.type = 5
ROLER_ENERGY_FIELD.cpp_type = 1

ROLER_GOLD_FIELD.name = "gold"
ROLER_GOLD_FIELD.full_name = ".Roler.gold"
ROLER_GOLD_FIELD.number = 3
ROLER_GOLD_FIELD.index = 2
ROLER_GOLD_FIELD.label = 2
ROLER_GOLD_FIELD.has_default_value = false
ROLER_GOLD_FIELD.default_value = 0
ROLER_GOLD_FIELD.type = 5
ROLER_GOLD_FIELD.cpp_type = 1

ROLER.name = "Roler"
ROLER.full_name = ".Roler"
ROLER.nested_types = {}
ROLER.enum_types = {}
ROLER.fields = {ROLER_ROLERID_FIELD, ROLER_ENERGY_FIELD, ROLER_GOLD_FIELD}
ROLER.is_extendable = false
ROLER.extensions = {}
ROLELOGINREQUEST_ROLEID_FIELD.name = "roleId"
ROLELOGINREQUEST_ROLEID_FIELD.full_name = ".RoleLoginRequest.roleId"
ROLELOGINREQUEST_ROLEID_FIELD.number = 1
ROLELOGINREQUEST_ROLEID_FIELD.index = 0
ROLELOGINREQUEST_ROLEID_FIELD.label = 2
ROLELOGINREQUEST_ROLEID_FIELD.has_default_value = false
ROLELOGINREQUEST_ROLEID_FIELD.default_value = 0
ROLELOGINREQUEST_ROLEID_FIELD.type = 5
ROLELOGINREQUEST_ROLEID_FIELD.cpp_type = 1

ROLELOGINREQUEST.name = "RoleLoginRequest"
ROLELOGINREQUEST.full_name = ".RoleLoginRequest"
ROLELOGINREQUEST.nested_types = {}
ROLELOGINREQUEST.enum_types = {}
ROLELOGINREQUEST.fields = {ROLELOGINREQUEST_ROLEID_FIELD}
ROLELOGINREQUEST.is_extendable = false
ROLELOGINREQUEST.extensions = {}
ROLELOGINRESPONSE_ROLE_FIELD.name = "role"
ROLELOGINRESPONSE_ROLE_FIELD.full_name = ".RoleLoginResponse.role"
ROLELOGINRESPONSE_ROLE_FIELD.number = 1
ROLELOGINRESPONSE_ROLE_FIELD.index = 0
ROLELOGINRESPONSE_ROLE_FIELD.label = 2
ROLELOGINRESPONSE_ROLE_FIELD.has_default_value = false
ROLELOGINRESPONSE_ROLE_FIELD.default_value = nil
ROLELOGINRESPONSE_ROLE_FIELD.message_type = ROLER
ROLELOGINRESPONSE_ROLE_FIELD.type = 11
ROLELOGINRESPONSE_ROLE_FIELD.cpp_type = 10

ROLELOGINRESPONSE.name = "RoleLoginResponse"
ROLELOGINRESPONSE.full_name = ".RoleLoginResponse"
ROLELOGINRESPONSE.nested_types = {}
ROLELOGINRESPONSE.enum_types = {}
ROLELOGINRESPONSE.fields = {ROLELOGINRESPONSE_ROLE_FIELD}
ROLELOGINRESPONSE.is_extendable = false
ROLELOGINRESPONSE.extensions = {}

CreateRoleRequest = protobuf.Message(CREATEROLEREQUEST)
CreateRoleResponse = protobuf.Message(CREATEROLERESPONSE)
HAS_USER = 0
ILLEGAL = 1
LAND_SUCCESS = 2
LoginRequest = protobuf.Message(LOGINREQUEST)
LoginResponse = protobuf.Message(LOGINRESPONSE)
NO_PASSWORD = 1
NO_USER = 0
REGISTER_SUCCESS = 2
RegisterRequest = protobuf.Message(REGISTERREQUEST)
RegisterResponse = protobuf.Message(REGISTERRESPONSE)
RoleLoginRequest = protobuf.Message(ROLELOGINREQUEST)
RoleLoginResponse = protobuf.Message(ROLELOGINRESPONSE)
Roler = protobuf.Message(ROLER)
