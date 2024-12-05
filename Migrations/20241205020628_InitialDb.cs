using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "gender_type",
                columns: table => new
                {
                    gender_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    gender_name = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender_type", x => x.gender_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "main_topic",
                columns: table => new
                {
                    topic_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    topic_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    color = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.topic_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "privacy_settings",
                columns: table => new
                {
                    privacy_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    privacy_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.privacy_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "type_media",
                columns: table => new
                {
                    type_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "type_post_notifications",
                columns: table => new
                {
                    type_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    content = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "type_relationship",
                columns: table => new
                {
                    type_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    first_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(255)", nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bio = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender_id = table.Column<int>(type: "int(1)", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()"),
                    date_updated = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.user_id);
                    table.ForeignKey(
                        name: "fk_gender",
                        column: x => x.gender_id,
                        principalTable: "gender_type",
                        principalColumn: "gender_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "media",
                columns: table => new
                {
                    media_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    src = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    hash_code = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    media_type = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.media_id);
                    table.ForeignKey(
                        name: "fk_type_media",
                        column: x => x.media_type,
                        principalTable: "type_media",
                        principalColumn: "type_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "history_search",
                columns: table => new
                {
                    history_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    other_user = table.Column<int>(type: "int(11)", nullable: true),
                    from_user = table.Column<int>(type: "int(11)", nullable: true),
                    date_search = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "current_timestamp()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.history_id);
                    table.ForeignKey(
                        name: "history_search_ibfk_1",
                        column: x => x.other_user,
                        principalTable: "user",
                        principalColumn: "user_id");
                    table.ForeignKey(
                        name: "history_search_ibfk_2",
                        column: x => x.from_user,
                        principalTable: "user",
                        principalColumn: "user_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "messages",
                columns: table => new
                {
                    messages_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    user_1 = table.Column<int>(type: "int(11)", nullable: false),
                    nickname_1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    user_2 = table.Column<int>(type: "int(11)", nullable: false),
                    nickname_2 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    main_topic = table.Column<int>(type: "int(11)", nullable: true, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.messages_id);
                    table.ForeignKey(
                        name: "fk_topic_main",
                        column: x => x.main_topic,
                        principalTable: "main_topic",
                        principalColumn: "topic_id");
                    table.ForeignKey(
                        name: "messages_ibfk_1",
                        column: x => x.user_1,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "messages_ibfk_2",
                        column: x => x.user_2,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "relationship",
                columns: table => new
                {
                    relationship_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type_relationship = table.Column<int>(type: "int(1)", nullable: true, defaultValueSql: "'0'"),
                    from_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    to_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    date_created = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.relationship_id);
                    table.ForeignKey(
                        name: "fk_relationship_from_user_id",
                        column: x => x.from_user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_relationship_to_user_id",
                        column: x => x.to_user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_type_relationship",
                        column: x => x.type_relationship,
                        principalTable: "type_relationship",
                        principalColumn: "type_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "request_notifications",
                columns: table => new
                {
                    notification_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    from_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    to_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    is_accept = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    is_read = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValueSql: "'0'"),
                    date_created = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.notification_id);
                    table.ForeignKey(
                        name: "fk_request_notifications_from_user_id",
                        column: x => x.from_user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_request_notifications_to_user_id",
                        column: x => x.to_user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "user_groups",
                columns: table => new
                {
                    group_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    group_name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    bio = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    profile_picture = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    cover_photo = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_created = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()"),
                    date_updated = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    created_by_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    privacy_id = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.group_id);
                    table.ForeignKey(
                        name: "fk_user_groups_created_by_user_id",
                        column: x => x.created_by_user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_groups_privacy_id",
                        column: x => x.privacy_id,
                        principalTable: "privacy_settings",
                        principalColumn: "privacy_id",
                        onDelete: ReferentialAction.SetNull);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "chat_in_message",
                columns: table => new
                {
                    chat_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    messages_id = table.Column<int>(type: "int(11)", nullable: false),
                    media_id = table.Column<int>(type: "int(1)", nullable: true),
                    is_read = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    is_recall = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    from_user = table.Column<int>(type: "int(11)", nullable: false),
                    content = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    is_notification = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    date_created = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.chat_id);
                    table.ForeignKey(
                        name: "chat_in_message_ibfk_1",
                        column: x => x.from_user,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "chat_in_message_ibfk_2",
                        column: x => x.messages_id,
                        principalTable: "messages",
                        principalColumn: "messages_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_media_chat",
                        column: x => x.media_id,
                        principalTable: "media",
                        principalColumn: "media_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "media_message",
                columns: table => new
                {
                    media_id = table.Column<int>(type: "int(11)", nullable: false),
                    message_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_media_message", x => new { x.media_id, x.message_id });
                    table.ForeignKey(
                        name: "fk_media_message",
                        column: x => x.media_id,
                        principalTable: "media",
                        principalColumn: "media_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_message_media",
                        column: x => x.message_id,
                        principalTable: "messages",
                        principalColumn: "messages_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "posts",
                columns: table => new
                {
                    post_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    content = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    privacy_id = table.Column<int>(type: "int(11)", nullable: true),
                    group_id = table.Column<int>(type: "int(11)", nullable: true),
                    created_by_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    is_profile_picture = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    is_cover_photo = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false),
                    date_created = table.Column<DateTime>(type: "timestamp", nullable: true, defaultValueSql: "current_timestamp()"),
                    date_updated = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn),
                    is_visible = table.Column<bool>(type: "tinyint(1)", nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.post_id);
                    table.ForeignKey(
                        name: "fk_posts_created_by_user_id",
                        column: x => x.created_by_user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_posts_group_id",
                        column: x => x.group_id,
                        principalTable: "user_groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "fk_posts_privacy_id",
                        column: x => x.privacy_id,
                        principalTable: "privacy_settings",
                        principalColumn: "privacy_id",
                        onDelete: ReferentialAction.SetNull);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "user_in_group",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    group_id = table.Column<int>(type: "int(11)", nullable: false),
                    date_in = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.user_id, x.group_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_user_in_group_group_id",
                        column: x => x.group_id,
                        principalTable: "user_groups",
                        principalColumn: "group_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_in_group_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    comment_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    post_id = table.Column<int>(type: "int(11)", nullable: true),
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    content = table.Column<string>(type: "text", nullable: false, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_created = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()"),
                    date_updated = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()"),
                    child_of = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.comment_id);
                    table.ForeignKey(
                        name: "fk_child_of",
                        column: x => x.child_of,
                        principalTable: "comments",
                        principalColumn: "comment_id");
                    table.ForeignKey(
                        name: "fk_comments_post_id",
                        column: x => x.post_id,
                        principalTable: "posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_comments_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "post_media",
                columns: table => new
                {
                    media_id = table.Column<int>(type: "int(11)", nullable: false),
                    post_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_post_media", x => new { x.media_id, x.post_id });
                    table.ForeignKey(
                        name: "FK_post_media_media_media_id",
                        column: x => x.media_id,
                        principalTable: "media",
                        principalColumn: "media_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_post_media_posts_post_id",
                        column: x => x.post_id,
                        principalTable: "posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "post_notifications",
                columns: table => new
                {
                    post_notification_id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    post_id = table.Column<int>(type: "int(11)", nullable: false),
                    from_user_id = table.Column<int>(type: "int(11)", nullable: false),
                    type_id = table.Column<int>(type: "int(11)", nullable: false),
                    is_read = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    date_created = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.post_notification_id);
                    table.ForeignKey(
                        name: "fk_post_notifications_from_user_id",
                        column: x => x.from_user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_post_notifications_post_id",
                        column: x => x.post_id,
                        principalTable: "posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_post_notifications_type",
                        column: x => x.type_id,
                        principalTable: "type_post_notifications",
                        principalColumn: "type_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "reacts_post",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    post_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reacts_post", x => new { x.post_id, x.user_id });
                    table.ForeignKey(
                        name: "fk_reacts_post_post_id",
                        column: x => x.post_id,
                        principalTable: "posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_reacts_post_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "share_posts",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    post_id = table.Column<int>(type: "int(11)", nullable: false),
                    date_share = table.Column<DateTime>(type: "timestamp", nullable: false, defaultValueSql: "current_timestamp()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.user_id, x.post_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "fk_share_posts_post_id",
                        column: x => x.post_id,
                        principalTable: "posts",
                        principalColumn: "post_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_share_posts_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "reacts_comment",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "int(11)", nullable: false),
                    comment_id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.user_id, x.comment_id });
                    table.ForeignKey(
                        name: "fk_reacts_comment_comment_id",
                        column: x => x.comment_id,
                        principalTable: "comments",
                        principalColumn: "comment_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_user_cloud",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.InsertData(
                table: "gender_type",
                columns: new[] { "gender_id", "gender_name" },
                values: new object[,]
                {
                    { 1, "Không cung cấp" },
                    { 2, "Nam" },
                    { 3, "Nữ" }
                });

            migrationBuilder.InsertData(
                table: "privacy_settings",
                columns: new[] { "privacy_id", "privacy_name" },
                values: new object[,]
                {
                    { 1, "Public" },
                    { 2, "Friends" },
                    { 3, "Private" }
                });

            migrationBuilder.InsertData(
                table: "type_media",
                columns: new[] { "type_id", "type_name" },
                values: new object[,]
                {
                    { 1, "Picture" },
                    { 2, "Video" },
                    { 3, "File" }
                });

            migrationBuilder.InsertData(
                table: "type_post_notifications",
                columns: new[] { "type_id", "content", "type_name" },
                values: new object[,]
                {
                    { 1, "đã đăng một bài viết mới", "newpost" },
                    { 2, "đã chia sẻ một bài viết của bạn", "sharepost" },
                    { 3, "đã thả cloud vào một bài viết của bạn", "likepost" },
                    { 4, "đã bình luận vào một bài viết của bạn", "comment" },
                    { 5, "đã thả cloud cho một comment của bạn", "likecomment" },
                    { 6, "đđã trả lời bình luận của bạn", "commentoncomment" }
                });

            migrationBuilder.InsertData(
                table: "type_relationship",
                columns: new[] { "type_id", "type_name" },
                values: new object[,]
                {
                    { 1, "Follower" },
                    { 2, "Friend" }
                });

            migrationBuilder.InsertData(
                table: "user",
                columns: new[] { "user_id", "bio", "email", "first_name", "gender_id", "last_name", "location", "password" },
                values: new object[,]
                {
                    { 1, null, "15@gmail.com", "Hấu", 1, "Dưa", null, "AQAAAAIAAYagAAAAEOYjiubhy6sR49wGjul/RSJOElGbL+T1BHdWMr6O2ATWaJcZLKnm49DaFKrkKPvoKA==" },
                    { 2, null, "10@gmail.com", "Đủ", 1, "Đu", null, "AQAAAAIAAYagAAAAEBIqogwoDD07RFh7d5XB0iO3XQfOiT4WLcH5jCQz53Ai5sqU2ebdhqaiWWRCChMEgg==" },
                    { 3, null, "12@gmail.com", "Riêng", 1, "Sầu", null, "AQAAAAIAAYagAAAAENdJI7tGR/5QBSoCakofqb73ExGowB6S2NmoMd4WLB3h2OJ5SvCqhWCRoQ4wsVxR+Q==" }
                });

            migrationBuilder.InsertData(
                table: "relationship",
                columns: new[] { "relationship_id", "from_user_id", "to_user_id", "type_relationship" },
                values: new object[,]
                {
                    { 1, 1, 2, 1 },
                    { 2, 1, 3, 2 },
                    { 3, 2, 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "from_user",
                table: "chat_in_message",
                column: "from_user");

            migrationBuilder.CreateIndex(
                name: "IX_chat_in_message_media_id",
                table: "chat_in_message",
                column: "media_id");

            migrationBuilder.CreateIndex(
                name: "messages_id",
                table: "chat_in_message",
                column: "messages_id");

            migrationBuilder.CreateIndex(
                name: "fk_child_of",
                table: "comments",
                column: "child_of");

            migrationBuilder.CreateIndex(
                name: "fk_comments_post_id",
                table: "comments",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "fk_comments_user_id",
                table: "comments",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "from_user1",
                table: "history_search",
                column: "from_user");

            migrationBuilder.CreateIndex(
                name: "other_user",
                table: "history_search",
                column: "other_user");

            migrationBuilder.CreateIndex(
                name: "fk_type_media",
                table: "media",
                column: "media_type");

            migrationBuilder.CreateIndex(
                name: "IX_media_message_message_id",
                table: "media_message",
                column: "message_id");

            migrationBuilder.CreateIndex(
                name: "fk_topic_main",
                table: "messages",
                column: "main_topic");

            migrationBuilder.CreateIndex(
                name: "user_1",
                table: "messages",
                column: "user_1");

            migrationBuilder.CreateIndex(
                name: "user_2",
                table: "messages",
                column: "user_2");

            migrationBuilder.CreateIndex(
                name: "IX_post_media_post_id",
                table: "post_media",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "fk_post_notifications_from_user_id",
                table: "post_notifications",
                column: "from_user_id");

            migrationBuilder.CreateIndex(
                name: "fk_post_notifications_post_id",
                table: "post_notifications",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "fk_post_notifications_type",
                table: "post_notifications",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "fk_posts_group_id",
                table: "posts",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "fk_posts_privacy_id",
                table: "posts",
                column: "privacy_id");

            migrationBuilder.CreateIndex(
                name: "idx_created_by_user_id_posts",
                table: "posts",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "fk_reacts_comment_comment_id",
                table: "reacts_comment",
                column: "comment_id");

            migrationBuilder.CreateIndex(
                name: "IX_reacts_comment_user_id",
                table: "reacts_comment",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_reacts_post_post_id",
                table: "reacts_post",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "fk_reacts_post_user_id",
                table: "reacts_post",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "fk_relationship_to_user_id",
                table: "relationship",
                column: "to_user_id");

            migrationBuilder.CreateIndex(
                name: "fk_type_relationship",
                table: "relationship",
                column: "type_relationship");

            migrationBuilder.CreateIndex(
                name: "from_user_id",
                table: "relationship",
                columns: new[] { "from_user_id", "to_user_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "fk_request_notifications_from_user_id",
                table: "request_notifications",
                column: "from_user_id");

            migrationBuilder.CreateIndex(
                name: "fk_request_notifications_to_user_id",
                table: "request_notifications",
                column: "to_user_id");

            migrationBuilder.CreateIndex(
                name: "fk_share_posts_post_id",
                table: "share_posts",
                column: "post_id");

            migrationBuilder.CreateIndex(
                name: "idx_username",
                table: "user",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_gender_id",
                table: "user",
                column: "gender_id");

            migrationBuilder.CreateIndex(
                name: "fk_user_groups_privacy_id",
                table: "user_groups",
                column: "privacy_id");

            migrationBuilder.CreateIndex(
                name: "idx_created_by_user_id",
                table: "user_groups",
                column: "created_by_user_id");

            migrationBuilder.CreateIndex(
                name: "fk_user_in_group_group_id",
                table: "user_in_group",
                column: "group_id");

            migrationBuilder.Sql("ALTER TABLE user AUTO_INCREMENT = 4;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "chat_in_message");

            migrationBuilder.DropTable(
                name: "history_search");

            migrationBuilder.DropTable(
                name: "media_message");

            migrationBuilder.DropTable(
                name: "post_media");

            migrationBuilder.DropTable(
                name: "post_notifications");

            migrationBuilder.DropTable(
                name: "reacts_comment");

            migrationBuilder.DropTable(
                name: "reacts_post");

            migrationBuilder.DropTable(
                name: "relationship");

            migrationBuilder.DropTable(
                name: "request_notifications");

            migrationBuilder.DropTable(
                name: "share_posts");

            migrationBuilder.DropTable(
                name: "user_in_group");

            migrationBuilder.DropTable(
                name: "messages");

            migrationBuilder.DropTable(
                name: "media");

            migrationBuilder.DropTable(
                name: "type_post_notifications");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "type_relationship");

            migrationBuilder.DropTable(
                name: "main_topic");

            migrationBuilder.DropTable(
                name: "type_media");

            migrationBuilder.DropTable(
                name: "posts");

            migrationBuilder.DropTable(
                name: "user_groups");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "privacy_settings");

            migrationBuilder.DropTable(
                name: "gender_type");
        }
    }
}
