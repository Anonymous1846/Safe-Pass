CREATE SCHEMA SAFEPASS;
CREATE TABLE IF NOT EXISTS SAFEPASS.USERS(
username varchar(20),
email varchar(20),
password varchar(100),
time_stamp datetime,
PRIMARY KEY(username)
);
CREATE TABLE IF NOT EXISTS SAFEPASS.user_passwords(
passwd_id INT AUTO_INCREMENT,
username varchar(20),
nickname varchar(20),
email_username varchar(30),
password varchar(100),
time_stamp datetime,
primary key(passwd_id,username),
foreign key(username) references safepass.users(username) on delete cascade
);