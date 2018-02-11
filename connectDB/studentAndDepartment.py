import psycopg2

try:
    # connect to the PostgreSQL database
    conn = psycopg2.connect("dbname='ESLAB' user='pi' host='192.168.43.168' password='448346'")
except:
    print("I am unable to connect ot the database")

# create a new cursor
cur = conn.cursor()

# execute the SELECT statement and others to get just the name and the department
cur.execute('''Select public."Student"."Name",public."Department"."Name" from public."Student",public."Department" where public."Student"."DepartmentID" = public."Department"."ID"''')

# get all the data
rows = cur.fetchall()

print("Show me the database:")
print()

# printout the rows
for row in rows:

    data = ""

    for r in row:
        data = data + "   " + str(r)
    
    print(data)