using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAbpStudy.Migrations
{
    public partial class Init_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_ABP_AUDIT_LOGS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: true),
                    F_SERVICE_NAME = table.Column<string>(maxLength: 256, nullable: true),
                    F_METHOD_NAME = table.Column<string>(maxLength: 256, nullable: true),
                    F_PARAMETERS = table.Column<string>(maxLength: 1024, nullable: true),
                    F_RETURN_VALUE = table.Column<string>(nullable: true),
                    F_EXECUTION_TIME = table.Column<DateTime>(nullable: false),
                    F_EXECUTION_DURATION = table.Column<int>(nullable: false),
                    F_CLIENT_IP_ADDRESS = table.Column<string>(maxLength: 64, nullable: true),
                    F_CLIENT_NAME = table.Column<string>(maxLength: 128, nullable: true),
                    F_BROWSER_INFO = table.Column<string>(maxLength: 512, nullable: true),
                    F_EXCEPTION = table.Column<string>(maxLength: 2000, nullable: true),
                    F_IMPERSONATOR_USER_ID = table.Column<long>(nullable: true),
                    F_IMPERSONATOR_TENANT_ID = table.Column<int>(nullable: true),
                    F_CUSTOM_DATA = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_AUDIT_LOGS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_BACKGROUND_JOBS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_JOB_TYPE = table.Column<string>(maxLength: 512, nullable: false),
                    F_JOB_ARGS = table.Column<string>(maxLength: 1048576, nullable: false),
                    F_TRY_COUNT = table.Column<short>(nullable: false),
                    F_NEXT_TRY_TIME = table.Column<DateTime>(nullable: false),
                    F_LAST_TRY_TIME = table.Column<DateTime>(nullable: true),
                    F_IS_ABANDONED = table.Column<bool>(nullable: false),
                    F_PRIORITY = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_BACKGROUND_JOBS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_CHANGE_SETS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_BROWSER_INFO = table.Column<string>(maxLength: 512, nullable: true),
                    F_CLIENT_IP_ADDRESS = table.Column<string>(maxLength: 64, nullable: true),
                    F_CLIENT_NAME = table.Column<string>(maxLength: 128, nullable: true),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_EXTENSION_DATA = table.Column<string>(nullable: true),
                    F_IMPERSONATOR_TENANT_ID = table.Column<int>(nullable: true),
                    F_IMPERSONATOR_USER_ID = table.Column<long>(nullable: true),
                    F_REASON = table.Column<string>(maxLength: 256, nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_CHANGE_SETS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_DYNAMIC_PARAMETERS",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_PARAMETER_NAME = table.Column<string>(nullable: true),
                    F_INPUT_TYPE = table.Column<string>(nullable: true),
                    F_PERMISSION = table.Column<string>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_DYNAMIC_PARAMETERS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_EDITIONS",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETER_USER_ID = table.Column<long>(nullable: true),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true),
                    F_NAME = table.Column<string>(maxLength: 32, nullable: false),
                    F_DISPLAY_NAME = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_EDITIONS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_LANGUAGE_TEXTS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_LANGUAGE_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    F_SOURCE = table.Column<string>(maxLength: 128, nullable: false),
                    F_KEY = table.Column<string>(maxLength: 256, nullable: false),
                    F_VALUE = table.Column<string>(maxLength: 67108864, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_LANGUAGE_TEXTS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_LANGUAGES",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETER_USER_ID = table.Column<long>(nullable: true),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    F_DISPLAY_NAME = table.Column<string>(maxLength: 64, nullable: false),
                    F_ICON = table.Column<string>(maxLength: 128, nullable: true),
                    F_IS_DISABLED = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_LANGUAGES", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_NOTIFICATION_SUBSCRIPTIONS",
                columns: table => new
                {
                    F_ID = table.Column<Guid>(nullable: false),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_NOTIFICATION_NAME = table.Column<string>(maxLength: 96, nullable: true),
                    F_ENTITY_TYPE_NAME = table.Column<string>(maxLength: 250, nullable: true),
                    F_ENTITY_TYPE_ASSEMBLY_QUALIFIED_NAME = table.Column<string>(maxLength: 512, nullable: true),
                    F_ENTITY_ID = table.Column<string>(maxLength: 96, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_NOTIFICATION_SUBSCRIPTIONS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_NOTIFICATIONS",
                columns: table => new
                {
                    F_ID = table.Column<Guid>(nullable: false),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_NOTIFICATION_NAME = table.Column<string>(maxLength: 96, nullable: false),
                    F_DATA = table.Column<string>(maxLength: 1048576, nullable: true),
                    F_DATA_TYPE_NAME = table.Column<string>(maxLength: 512, nullable: true),
                    F_ENTITY_TYPE_NAME = table.Column<string>(maxLength: 250, nullable: true),
                    F_ENTITY_TYPE_ASSEMBLY_QUALIFIED_NAME = table.Column<string>(maxLength: 512, nullable: true),
                    F_ENTITY_ID = table.Column<string>(maxLength: 96, nullable: true),
                    F_SEVERITY = table.Column<byte>(nullable: false),
                    F_USER_IDS = table.Column<string>(maxLength: 131072, nullable: true),
                    F_EXCLUDED_USER_IDS = table.Column<string>(maxLength: 131072, nullable: true),
                    F_TENANT_IDS = table.Column<string>(maxLength: 131072, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_NOTIFICATIONS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_ORGANIZATION_UNIT_ROLES",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_ROLE_ID = table.Column<int>(nullable: false),
                    F_ORGANIZATION_UNIT_ID = table.Column<long>(nullable: false),
                    F_IS_DELETED = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_ORGANIZATION_UNIT_ROLES", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_ORGANIZATION_UNITS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETER_USER_ID = table.Column<long>(nullable: true),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_PARENT_ID = table.Column<long>(nullable: true),
                    F_CODE = table.Column<string>(maxLength: 95, nullable: false),
                    F_DISPLAY_NAME = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_ORGANIZATION_UNITS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_ORGANIZATION_UNITS_T_ABP_ORGANIZATION_UNITS_F_PARENT_ID",
                        column: x => x.F_PARENT_ID,
                        principalTable: "T_ABP_ORGANIZATION_UNITS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_TENANT_NOTIFICATIONS",
                columns: table => new
                {
                    F_ID = table.Column<Guid>(nullable: false),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_NOTIFICATION_NAME = table.Column<string>(maxLength: 96, nullable: false),
                    F_DATA = table.Column<string>(maxLength: 1048576, nullable: true),
                    F_DATA_TYPE_NAME = table.Column<string>(maxLength: 512, nullable: true),
                    F_ENTITY_TYPE_NAME = table.Column<string>(maxLength: 250, nullable: true),
                    F_ENTITY_TYPE_ASSEMBLY_QUALIFIED_NAME = table.Column<string>(maxLength: 512, nullable: true),
                    F_ENTITY_ID = table.Column<string>(maxLength: 96, nullable: true),
                    F_SEVERITY = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_TENANT_NOTIFICATIONS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_ACCOUNTS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETER_USER_ID = table.Column<long>(nullable: true),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_USER_LINK_ID = table.Column<long>(nullable: true),
                    F_USER_NAME = table.Column<string>(maxLength: 256, nullable: true),
                    F_EMAIL_ADDRESS = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_ACCOUNTS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_LOGIN_ATTEMPTS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_TENANCY_NAME = table.Column<string>(maxLength: 64, nullable: true),
                    F_USER_ID = table.Column<long>(nullable: true),
                    F_USER_NAME_OR_EMAIL_ADDRESS = table.Column<string>(maxLength: 256, nullable: true),
                    F_CLIENT_IP_ADDRESS = table.Column<string>(maxLength: 64, nullable: true),
                    F_CLIENT_NAME = table.Column<string>(maxLength: 128, nullable: true),
                    F_BROWSER_INFO = table.Column<string>(maxLength: 512, nullable: true),
                    F_RESULT = table.Column<byte>(nullable: false),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_LOGIN_ATTEMPTS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_NOTIFICATIONS",
                columns: table => new
                {
                    F_ID = table.Column<Guid>(nullable: false),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_TENANT_NOTIFICATION_ID = table.Column<Guid>(nullable: false),
                    F_STATE = table.Column<int>(nullable: false),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_NOTIFICATIONS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_ORGANIZATION_UNITS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_ORGANIZATION_UNIT_ID = table.Column<long>(nullable: false),
                    F_IS_DELETED = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_ORGANIZATION_UNITS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USERS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETER_USER_ID = table.Column<long>(nullable: true),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true),
                    F_AUTHENTICATION_SOURCE = table.Column<string>(maxLength: 64, nullable: true),
                    F_USER_NAME = table.Column<string>(maxLength: 256, nullable: false),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_EMAIL_ADDRESS = table.Column<string>(maxLength: 256, nullable: false),
                    F_NAME = table.Column<string>(maxLength: 64, nullable: false),
                    F_SURNAME = table.Column<string>(maxLength: 64, nullable: false),
                    F_PASSWORD = table.Column<string>(maxLength: 128, nullable: false),
                    F_EMAIL_CONFIRMATION_CODE = table.Column<string>(maxLength: 328, nullable: true),
                    F_PASSWORD_RESET_CODE = table.Column<string>(maxLength: 328, nullable: true),
                    F_LOCKOUT_END_DATE_UTC = table.Column<DateTime>(nullable: true),
                    F_ACCESS_FAILED_COUNT = table.Column<int>(nullable: false),
                    F_IS_LOCKOUT_ENABLED = table.Column<bool>(nullable: false),
                    F_PHONE_NUMBER = table.Column<string>(maxLength: 32, nullable: true),
                    F_IS_PHONE_NUMBER_CONFIRMED = table.Column<bool>(nullable: false),
                    F_SECURITY_STAMP = table.Column<string>(maxLength: 128, nullable: true),
                    F_IS_TWO_FACTOR_ENABLED = table.Column<bool>(nullable: false),
                    F_IS_EMAIL_CONFIRMED = table.Column<bool>(nullable: false),
                    F_IS_ACTIVE = table.Column<bool>(nullable: false),
                    F_NORMALIZED_USER_NAME = table.Column<string>(maxLength: 256, nullable: false),
                    F_NORMALIZED_EMAIL_ADDRESS = table.Column<string>(maxLength: 256, nullable: false),
                    F_CONCURRENCY_STAMP = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USERS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_USERS_T_ABP_USERS_F_CREATOR_USER_ID",
                        column: x => x.F_CREATOR_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ABP_USERS_T_ABP_USERS_F_DELETER_USER_ID",
                        column: x => x.F_DELETER_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ABP_USERS_T_ABP_USERS_F_LAST_MODIFIER_USER_ID",
                        column: x => x.F_LAST_MODIFIER_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_WEBHOOK_EVENTS",
                columns: table => new
                {
                    F_ID = table.Column<Guid>(nullable: false),
                    F_WEBHOOK_NAME = table.Column<string>(nullable: false),
                    F_DATA = table.Column<string>(nullable: true),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_WEBHOOK_EVENTS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_WEBHOOK_SUBSCRIPTIONS",
                columns: table => new
                {
                    F_ID = table.Column<Guid>(nullable: false),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_WEBHOOK_URI = table.Column<string>(nullable: false),
                    F_SECRET = table.Column<string>(nullable: false),
                    F_IS_ACTIVE = table.Column<bool>(nullable: false),
                    F_WEBHOOKS = table.Column<string>(nullable: true),
                    F_HEADERS = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_WEBHOOK_SUBSCRIPTIONS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_COURIER_COMPANYS",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_COURIER_ID = table.Column<long>(nullable: true),
                    F_COURIER_NAME = table.Column<string>(nullable: true),
                    F_COURIER_PEOPLE = table.Column<string>(nullable: true),
                    F_PHONE_NUMBER = table.Column<long>(maxLength: 11, nullable: false),
                    F_MONEY = table.Column<double>(nullable: false),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_COURIER_COMPANYS", x => x.F_ID);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_CHANGES",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CHANGE_TIME = table.Column<DateTime>(nullable: false),
                    F_CHANGE_TYPE = table.Column<byte>(nullable: false),
                    F_ENTITY_CHANGE_SET_ID = table.Column<long>(nullable: false),
                    F_ENTITY_ID = table.Column<string>(maxLength: 48, nullable: true),
                    F_ENTITY_TYPE_FULL_NAME = table.Column<string>(maxLength: 192, nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_CHANGES", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_CHANGES_T_ABP_CHANGE_SETS_F_ENTITY_CHANGE_SET_ID",
                        column: x => x.F_ENTITY_CHANGE_SET_ID,
                        principalTable: "T_ABP_CHANGE_SETS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityDynamicParameters",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_ENTITY_FULL_NAME = table.Column<string>(nullable: true),
                    F_DYNAMIC_PARAMETER_ID = table.Column<int>(nullable: false),
                    F_TENANT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityDynamicParameters", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_AbpEntityDynamicParameters_T_ABP_DYNAMIC_PARAMETERS_F_DYNAMIC_PARAMETER_ID",
                        column: x => x.F_DYNAMIC_PARAMETER_ID,
                        principalTable: "T_ABP_DYNAMIC_PARAMETERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_DYNAMIC_PARAMETER_VALUES",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_VALUE = table.Column<string>(nullable: false),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_DYNAMIC_PARAMETER_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_DYNAMIC_PARAMETER_VALUES", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_DYNAMIC_PARAMETER_VALUES_T_ABP_DYNAMIC_PARAMETERS_F_DYNAMIC_PARAMETER_ID",
                        column: x => x.F_DYNAMIC_PARAMETER_ID,
                        principalTable: "T_ABP_DYNAMIC_PARAMETERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_FEATURES",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    F_VALUE = table.Column<string>(maxLength: 2000, nullable: false),
                    F_DISCRIMINATOR = table.Column<string>(nullable: false),
                    F_EDITION_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_FEATURES", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_FEATURES_T_ABP_EDITIONS_F_EDITION_ID",
                        column: x => x.F_EDITION_ID,
                        principalTable: "T_ABP_EDITIONS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_ROLES",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETER_USER_ID = table.Column<long>(nullable: true),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_NAME = table.Column<string>(maxLength: 32, nullable: false),
                    F_DISPLAY_NAME = table.Column<string>(maxLength: 64, nullable: false),
                    F_IS_STATIC = table.Column<bool>(nullable: false),
                    F_IS_DEFAULT = table.Column<bool>(nullable: false),
                    F_NORMALIZED_NAME = table.Column<string>(maxLength: 32, nullable: false),
                    F_CONCURRENCY_STAMP = table.Column<string>(maxLength: 128, nullable: true),
                    F_DESCRIPTION = table.Column<string>(maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_ROLES", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_ROLES_T_ABP_USERS_F_CREATOR_USER_ID",
                        column: x => x.F_CREATOR_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ABP_ROLES_T_ABP_USERS_F_DELETER_USER_ID",
                        column: x => x.F_DELETER_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ABP_ROLES_T_ABP_USERS_F_LAST_MODIFIER_USER_ID",
                        column: x => x.F_LAST_MODIFIER_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_SETTINGS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: true),
                    F_NAME = table.Column<string>(maxLength: 256, nullable: false),
                    F_VALUE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_SETTINGS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_SETTINGS_T_ABP_USERS_F_USER_ID",
                        column: x => x.F_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_TENANTS",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_LAST_MODIFIER_USER_ID = table.Column<long>(nullable: true),
                    F_IS_DELETED = table.Column<bool>(nullable: false),
                    F_DELETER_USER_ID = table.Column<long>(nullable: true),
                    F_DELETION_TIME = table.Column<DateTime>(nullable: true),
                    F_TENANCY_NAME = table.Column<string>(maxLength: 64, nullable: false),
                    F_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    F_CONNECTION_STRING = table.Column<string>(maxLength: 1024, nullable: true),
                    F_IS_ACTIVE = table.Column<bool>(nullable: false),
                    F_EDITION_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_TENANTS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_TENANTS_T_ABP_USERS_F_CREATOR_USER_ID",
                        column: x => x.F_CREATOR_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ABP_TENANTS_T_ABP_USERS_F_DELETER_USER_ID",
                        column: x => x.F_DELETER_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ABP_TENANTS_T_ABP_EDITIONS_F_EDITION_ID",
                        column: x => x.F_EDITION_ID,
                        principalTable: "T_ABP_EDITIONS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_ABP_TENANTS_T_ABP_USERS_F_LAST_MODIFIER_USER_ID",
                        column: x => x.F_LAST_MODIFIER_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_CLAIMS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_CLAIM_TYPE = table.Column<string>(maxLength: 256, nullable: true),
                    F_CLAIM_VALUE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_CLAIMS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_USER_CLAIMS_T_ABP_USERS_F_USER_ID",
                        column: x => x.F_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_LOGINS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_LOGIN_PROVIDER = table.Column<string>(maxLength: 128, nullable: false),
                    F_PROVIDER_KEY = table.Column<string>(maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_LOGINS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_USER_LOGINS_T_ABP_USERS_F_USER_ID",
                        column: x => x.F_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_ROLES",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_ROLE_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_ROLES", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_USER_ROLES_T_ABP_USERS_F_USER_ID",
                        column: x => x.F_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_USER_TOKENS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: false),
                    F_LOGIN_PROVIDER = table.Column<string>(maxLength: 128, nullable: true),
                    F_NAME = table.Column<string>(maxLength: 128, nullable: true),
                    F_VALUE = table.Column<string>(maxLength: 512, nullable: true),
                    F_EXPIRE_DATE = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_USER_TOKENS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_USER_TOKENS_T_ABP_USERS_F_USER_ID",
                        column: x => x.F_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_WEBHOOK_SEND_ATTEMPTS",
                columns: table => new
                {
                    F_ID = table.Column<Guid>(nullable: false),
                    F_WEBHOOK_EVENT_ID = table.Column<Guid>(nullable: false),
                    F_WEBHOOK_SUBSCRIPTION_ID = table.Column<Guid>(nullable: false),
                    F_RESPONSE = table.Column<string>(nullable: true),
                    F_RESPONSE_STATUS_CODE = table.Column<int>(nullable: true),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_LAST_MODIFICATION_TIME = table.Column<DateTime>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_WEBHOOK_SEND_ATTEMPTS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_WEBHOOK_SEND_ATTEMPTS_T_ABP_WEBHOOK_EVENTS_F_WEBHOOK_EVENT_ID",
                        column: x => x.F_WEBHOOK_EVENT_ID,
                        principalTable: "T_ABP_WEBHOOK_EVENTS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_PROPERTY_CHANGES",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_ENTITY_CHANGE_ID = table.Column<long>(nullable: false),
                    F_NEW_VALUE = table.Column<string>(maxLength: 512, nullable: true),
                    F_ORIGINAL_VALUE = table.Column<string>(maxLength: 512, nullable: true),
                    F_PROPERTY_NAME = table.Column<string>(maxLength: 96, nullable: true),
                    F_PROPERTY_TYPE_FULL_NAME = table.Column<string>(maxLength: 192, nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_PROPERTY_CHANGES", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_PROPERTY_CHANGES_T_ABP_CHANGES_F_ENTITY_CHANGE_ID",
                        column: x => x.F_ENTITY_CHANGE_ID,
                        principalTable: "T_ABP_CHANGES",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityDynamicParameterValues",
                columns: table => new
                {
                    F_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_VALUE = table.Column<string>(nullable: false),
                    F_ENTITY_ID = table.Column<string>(nullable: true),
                    F_ENTITY_DYNAMIC_PARAMETER_ID = table.Column<int>(nullable: false),
                    F_TENANT_ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityDynamicParameterValues", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_AbpEntityDynamicParameterValues_AbpEntityDynamicParameters_F_ENTITY_DYNAMIC_PARAMETER_ID",
                        column: x => x.F_ENTITY_DYNAMIC_PARAMETER_ID,
                        principalTable: "AbpEntityDynamicParameters",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_PERMISSIONS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_NAME = table.Column<string>(maxLength: 128, nullable: false),
                    F_IS_GRANTED = table.Column<bool>(nullable: false),
                    F_DISCRIMINATOR = table.Column<string>(nullable: false),
                    F_ROLE_ID = table.Column<int>(nullable: true),
                    F_USER_ID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_PERMISSIONS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_PERMISSIONS_T_ABP_ROLES_F_ROLE_ID",
                        column: x => x.F_ROLE_ID,
                        principalTable: "T_ABP_ROLES",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_T_ABP_PERMISSIONS_T_ABP_USERS_F_USER_ID",
                        column: x => x.F_USER_ID,
                        principalTable: "T_ABP_USERS",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "T_ABP_ROLE_CLAIMS",
                columns: table => new
                {
                    F_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F_CREATION_TIME = table.Column<DateTime>(nullable: false),
                    F_CREATOR_USER_ID = table.Column<long>(nullable: true),
                    F_TENANT_ID = table.Column<int>(nullable: true),
                    F_ROLE_ID = table.Column<int>(nullable: false),
                    F_CLAIM_TYPE = table.Column<string>(maxLength: 256, nullable: true),
                    F_CLAIM_VALUE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ABP_ROLE_CLAIMS", x => x.F_ID);
                    table.ForeignKey(
                        name: "FK_T_ABP_ROLE_CLAIMS_T_ABP_ROLES_F_ROLE_ID",
                        column: x => x.F_ROLE_ID,
                        principalTable: "T_ABP_ROLES",
                        principalColumn: "F_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityDynamicParameters_F_DYNAMIC_PARAMETER_ID",
                table: "AbpEntityDynamicParameters",
                column: "F_DYNAMIC_PARAMETER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityDynamicParameters_F_ENTITY_FULL_NAME_F_DYNAMIC_PARAMETER_ID_F_TENANT_ID",
                table: "AbpEntityDynamicParameters",
                columns: new[] { "F_ENTITY_FULL_NAME", "F_DYNAMIC_PARAMETER_ID", "F_TENANT_ID" },
                unique: true,
                filter: "[F_ENTITY_FULL_NAME] IS NOT NULL AND [F_TENANT_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityDynamicParameterValues_F_ENTITY_DYNAMIC_PARAMETER_ID",
                table: "AbpEntityDynamicParameterValues",
                column: "F_ENTITY_DYNAMIC_PARAMETER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_AUDIT_LOGS_F_TENANT_ID_F_EXECUTION_DURATION",
                table: "T_ABP_AUDIT_LOGS",
                columns: new[] { "F_TENANT_ID", "F_EXECUTION_DURATION" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_AUDIT_LOGS_F_TENANT_ID_F_EXECUTION_TIME",
                table: "T_ABP_AUDIT_LOGS",
                columns: new[] { "F_TENANT_ID", "F_EXECUTION_TIME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_AUDIT_LOGS_F_TENANT_ID_F_USER_ID",
                table: "T_ABP_AUDIT_LOGS",
                columns: new[] { "F_TENANT_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_BACKGROUND_JOBS_F_IS_ABANDONED_F_NEXT_TRY_TIME",
                table: "T_ABP_BACKGROUND_JOBS",
                columns: new[] { "F_IS_ABANDONED", "F_NEXT_TRY_TIME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_CHANGE_SETS_F_TENANT_ID_F_CREATION_TIME",
                table: "T_ABP_CHANGE_SETS",
                columns: new[] { "F_TENANT_ID", "F_CREATION_TIME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_CHANGE_SETS_F_TENANT_ID_F_REASON",
                table: "T_ABP_CHANGE_SETS",
                columns: new[] { "F_TENANT_ID", "F_REASON" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_CHANGE_SETS_F_TENANT_ID_F_USER_ID",
                table: "T_ABP_CHANGE_SETS",
                columns: new[] { "F_TENANT_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_CHANGES_F_ENTITY_CHANGE_SET_ID",
                table: "T_ABP_CHANGES",
                column: "F_ENTITY_CHANGE_SET_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_CHANGES_F_ENTITY_TYPE_FULL_NAME_F_ENTITY_ID",
                table: "T_ABP_CHANGES",
                columns: new[] { "F_ENTITY_TYPE_FULL_NAME", "F_ENTITY_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_DYNAMIC_PARAMETER_VALUES_F_DYNAMIC_PARAMETER_ID",
                table: "T_ABP_DYNAMIC_PARAMETER_VALUES",
                column: "F_DYNAMIC_PARAMETER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_DYNAMIC_PARAMETERS_F_PARAMETER_NAME_F_TENANT_ID",
                table: "T_ABP_DYNAMIC_PARAMETERS",
                columns: new[] { "F_PARAMETER_NAME", "F_TENANT_ID" },
                unique: true,
                filter: "[F_PARAMETER_NAME] IS NOT NULL AND [F_TENANT_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_FEATURES_F_EDITION_ID_F_NAME",
                table: "T_ABP_FEATURES",
                columns: new[] { "F_EDITION_ID", "F_NAME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_FEATURES_F_TENANT_ID_F_NAME",
                table: "T_ABP_FEATURES",
                columns: new[] { "F_TENANT_ID", "F_NAME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_LANGUAGE_TEXTS_F_TENANT_ID_F_SOURCE_F_LANGUAGE_NAME_F_KEY",
                table: "T_ABP_LANGUAGE_TEXTS",
                columns: new[] { "F_TENANT_ID", "F_SOURCE", "F_LANGUAGE_NAME", "F_KEY" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_LANGUAGES_F_TENANT_ID_F_NAME",
                table: "T_ABP_LANGUAGES",
                columns: new[] { "F_TENANT_ID", "F_NAME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_NOTIFICATION_SUBSCRIPTIONS_F_NOTIFICATION_NAME_F_ENTITY_TYPE_NAME_F_ENTITY_ID_F_USER_ID",
                table: "T_ABP_NOTIFICATION_SUBSCRIPTIONS",
                columns: new[] { "F_NOTIFICATION_NAME", "F_ENTITY_TYPE_NAME", "F_ENTITY_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_NOTIFICATION_SUBSCRIPTIONS_F_TENANT_ID_F_NOTIFICATION_NAME_F_ENTITY_TYPE_NAME_F_ENTITY_ID_F_USER_ID",
                table: "T_ABP_NOTIFICATION_SUBSCRIPTIONS",
                columns: new[] { "F_TENANT_ID", "F_NOTIFICATION_NAME", "F_ENTITY_TYPE_NAME", "F_ENTITY_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ORGANIZATION_UNIT_ROLES_F_TENANT_ID_F_ORGANIZATION_UNIT_ID",
                table: "T_ABP_ORGANIZATION_UNIT_ROLES",
                columns: new[] { "F_TENANT_ID", "F_ORGANIZATION_UNIT_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ORGANIZATION_UNIT_ROLES_F_TENANT_ID_F_ROLE_ID",
                table: "T_ABP_ORGANIZATION_UNIT_ROLES",
                columns: new[] { "F_TENANT_ID", "F_ROLE_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ORGANIZATION_UNITS_F_PARENT_ID",
                table: "T_ABP_ORGANIZATION_UNITS",
                column: "F_PARENT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ORGANIZATION_UNITS_F_TENANT_ID_F_CODE",
                table: "T_ABP_ORGANIZATION_UNITS",
                columns: new[] { "F_TENANT_ID", "F_CODE" },
                unique: true,
                filter: "[F_TENANT_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_PERMISSIONS_F_TENANT_ID_F_NAME",
                table: "T_ABP_PERMISSIONS",
                columns: new[] { "F_TENANT_ID", "F_NAME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_PERMISSIONS_F_ROLE_ID",
                table: "T_ABP_PERMISSIONS",
                column: "F_ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_PERMISSIONS_F_USER_ID",
                table: "T_ABP_PERMISSIONS",
                column: "F_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_PROPERTY_CHANGES_F_ENTITY_CHANGE_ID",
                table: "T_ABP_PROPERTY_CHANGES",
                column: "F_ENTITY_CHANGE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ROLE_CLAIMS_F_ROLE_ID",
                table: "T_ABP_ROLE_CLAIMS",
                column: "F_ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ROLE_CLAIMS_F_TENANT_ID_F_CLAIM_TYPE",
                table: "T_ABP_ROLE_CLAIMS",
                columns: new[] { "F_TENANT_ID", "F_CLAIM_TYPE" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ROLES_F_CREATOR_USER_ID",
                table: "T_ABP_ROLES",
                column: "F_CREATOR_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ROLES_F_DELETER_USER_ID",
                table: "T_ABP_ROLES",
                column: "F_DELETER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ROLES_F_LAST_MODIFIER_USER_ID",
                table: "T_ABP_ROLES",
                column: "F_LAST_MODIFIER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_ROLES_F_TENANT_ID_F_NORMALIZED_NAME",
                table: "T_ABP_ROLES",
                columns: new[] { "F_TENANT_ID", "F_NORMALIZED_NAME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_SETTINGS_F_USER_ID",
                table: "T_ABP_SETTINGS",
                column: "F_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_SETTINGS_F_TENANT_ID_F_NAME_F_USER_ID",
                table: "T_ABP_SETTINGS",
                columns: new[] { "F_TENANT_ID", "F_NAME", "F_USER_ID" },
                unique: true,
                filter: "[F_TENANT_ID] IS NOT NULL AND [F_USER_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_TENANT_NOTIFICATIONS_F_TENANT_ID",
                table: "T_ABP_TENANT_NOTIFICATIONS",
                column: "F_TENANT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_TENANTS_F_CREATOR_USER_ID",
                table: "T_ABP_TENANTS",
                column: "F_CREATOR_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_TENANTS_F_DELETER_USER_ID",
                table: "T_ABP_TENANTS",
                column: "F_DELETER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_TENANTS_F_EDITION_ID",
                table: "T_ABP_TENANTS",
                column: "F_EDITION_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_TENANTS_F_LAST_MODIFIER_USER_ID",
                table: "T_ABP_TENANTS",
                column: "F_LAST_MODIFIER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_TENANTS_F_TENANCY_NAME",
                table: "T_ABP_TENANTS",
                column: "F_TENANCY_NAME");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ACCOUNTS_F_EMAIL_ADDRESS",
                table: "T_ABP_USER_ACCOUNTS",
                column: "F_EMAIL_ADDRESS");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ACCOUNTS_F_USER_NAME",
                table: "T_ABP_USER_ACCOUNTS",
                column: "F_USER_NAME");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ACCOUNTS_F_TENANT_ID_F_EMAIL_ADDRESS",
                table: "T_ABP_USER_ACCOUNTS",
                columns: new[] { "F_TENANT_ID", "F_EMAIL_ADDRESS" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ACCOUNTS_F_TENANT_ID_F_USER_ID",
                table: "T_ABP_USER_ACCOUNTS",
                columns: new[] { "F_TENANT_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ACCOUNTS_F_TENANT_ID_F_USER_NAME",
                table: "T_ABP_USER_ACCOUNTS",
                columns: new[] { "F_TENANT_ID", "F_USER_NAME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_CLAIMS_F_USER_ID",
                table: "T_ABP_USER_CLAIMS",
                column: "F_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_CLAIMS_F_TENANT_ID_F_CLAIM_TYPE",
                table: "T_ABP_USER_CLAIMS",
                columns: new[] { "F_TENANT_ID", "F_CLAIM_TYPE" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_LOGIN_ATTEMPTS_F_USER_ID_F_TENANT_ID",
                table: "T_ABP_USER_LOGIN_ATTEMPTS",
                columns: new[] { "F_USER_ID", "F_TENANT_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_LOGIN_ATTEMPTS_F_TENANCY_NAME_F_USER_NAME_OR_EMAIL_ADDRESS_F_RESULT",
                table: "T_ABP_USER_LOGIN_ATTEMPTS",
                columns: new[] { "F_TENANCY_NAME", "F_USER_NAME_OR_EMAIL_ADDRESS", "F_RESULT" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_LOGINS_F_USER_ID",
                table: "T_ABP_USER_LOGINS",
                column: "F_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_LOGINS_F_TENANT_ID_F_USER_ID",
                table: "T_ABP_USER_LOGINS",
                columns: new[] { "F_TENANT_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_LOGINS_F_TENANT_ID_F_LOGIN_PROVIDER_F_PROVIDER_KEY",
                table: "T_ABP_USER_LOGINS",
                columns: new[] { "F_TENANT_ID", "F_LOGIN_PROVIDER", "F_PROVIDER_KEY" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_NOTIFICATIONS_F_USER_ID_F_STATE_F_CREATION_TIME",
                table: "T_ABP_USER_NOTIFICATIONS",
                columns: new[] { "F_USER_ID", "F_STATE", "F_CREATION_TIME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ORGANIZATION_UNITS_F_TENANT_ID_F_ORGANIZATION_UNIT_ID",
                table: "T_ABP_USER_ORGANIZATION_UNITS",
                columns: new[] { "F_TENANT_ID", "F_ORGANIZATION_UNIT_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ORGANIZATION_UNITS_F_TENANT_ID_F_USER_ID",
                table: "T_ABP_USER_ORGANIZATION_UNITS",
                columns: new[] { "F_TENANT_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ROLES_F_USER_ID",
                table: "T_ABP_USER_ROLES",
                column: "F_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ROLES_F_TENANT_ID_F_ROLE_ID",
                table: "T_ABP_USER_ROLES",
                columns: new[] { "F_TENANT_ID", "F_ROLE_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_ROLES_F_TENANT_ID_F_USER_ID",
                table: "T_ABP_USER_ROLES",
                columns: new[] { "F_TENANT_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_TOKENS_F_USER_ID",
                table: "T_ABP_USER_TOKENS",
                column: "F_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USER_TOKENS_F_TENANT_ID_F_USER_ID",
                table: "T_ABP_USER_TOKENS",
                columns: new[] { "F_TENANT_ID", "F_USER_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USERS_F_CREATOR_USER_ID",
                table: "T_ABP_USERS",
                column: "F_CREATOR_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USERS_F_DELETER_USER_ID",
                table: "T_ABP_USERS",
                column: "F_DELETER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USERS_F_LAST_MODIFIER_USER_ID",
                table: "T_ABP_USERS",
                column: "F_LAST_MODIFIER_USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USERS_F_TENANT_ID_F_NORMALIZED_EMAIL_ADDRESS",
                table: "T_ABP_USERS",
                columns: new[] { "F_TENANT_ID", "F_NORMALIZED_EMAIL_ADDRESS" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_USERS_F_TENANT_ID_F_NORMALIZED_USER_NAME",
                table: "T_ABP_USERS",
                columns: new[] { "F_TENANT_ID", "F_NORMALIZED_USER_NAME" });

            migrationBuilder.CreateIndex(
                name: "IX_T_ABP_WEBHOOK_SEND_ATTEMPTS_F_WEBHOOK_EVENT_ID",
                table: "T_ABP_WEBHOOK_SEND_ATTEMPTS",
                column: "F_WEBHOOK_EVENT_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpEntityDynamicParameterValues");

            migrationBuilder.DropTable(
                name: "T_ABP_AUDIT_LOGS");

            migrationBuilder.DropTable(
                name: "T_ABP_BACKGROUND_JOBS");

            migrationBuilder.DropTable(
                name: "T_ABP_DYNAMIC_PARAMETER_VALUES");

            migrationBuilder.DropTable(
                name: "T_ABP_FEATURES");

            migrationBuilder.DropTable(
                name: "T_ABP_LANGUAGE_TEXTS");

            migrationBuilder.DropTable(
                name: "T_ABP_LANGUAGES");

            migrationBuilder.DropTable(
                name: "T_ABP_NOTIFICATION_SUBSCRIPTIONS");

            migrationBuilder.DropTable(
                name: "T_ABP_NOTIFICATIONS");

            migrationBuilder.DropTable(
                name: "T_ABP_ORGANIZATION_UNIT_ROLES");

            migrationBuilder.DropTable(
                name: "T_ABP_ORGANIZATION_UNITS");

            migrationBuilder.DropTable(
                name: "T_ABP_PERMISSIONS");

            migrationBuilder.DropTable(
                name: "T_ABP_PROPERTY_CHANGES");

            migrationBuilder.DropTable(
                name: "T_ABP_ROLE_CLAIMS");

            migrationBuilder.DropTable(
                name: "T_ABP_SETTINGS");

            migrationBuilder.DropTable(
                name: "T_ABP_TENANT_NOTIFICATIONS");

            migrationBuilder.DropTable(
                name: "T_ABP_TENANTS");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_ACCOUNTS");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_CLAIMS");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_LOGIN_ATTEMPTS");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_LOGINS");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_NOTIFICATIONS");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_ORGANIZATION_UNITS");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_ROLES");

            migrationBuilder.DropTable(
                name: "T_ABP_USER_TOKENS");

            migrationBuilder.DropTable(
                name: "T_ABP_WEBHOOK_SEND_ATTEMPTS");

            migrationBuilder.DropTable(
                name: "T_ABP_WEBHOOK_SUBSCRIPTIONS");

            migrationBuilder.DropTable(
                name: "T_COURIER_COMPANYS");

            migrationBuilder.DropTable(
                name: "AbpEntityDynamicParameters");

            migrationBuilder.DropTable(
                name: "T_ABP_CHANGES");

            migrationBuilder.DropTable(
                name: "T_ABP_ROLES");

            migrationBuilder.DropTable(
                name: "T_ABP_EDITIONS");

            migrationBuilder.DropTable(
                name: "T_ABP_WEBHOOK_EVENTS");

            migrationBuilder.DropTable(
                name: "T_ABP_DYNAMIC_PARAMETERS");

            migrationBuilder.DropTable(
                name: "T_ABP_CHANGE_SETS");

            migrationBuilder.DropTable(
                name: "T_ABP_USERS");
        }
    }
}
