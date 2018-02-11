import psycopg2

def insertValue(student_id, name, phoneNumber, advisorID, departmentID):
    
    studentID = None
    query = '''INSERT INTO public."Student"("ID", "Name", "PhoneNumber", "AdvisorID", "DepartmentID") VALUES (%s,%s,%s,%s,%s) RETURNING "ID";'''

    try:
        # connect to the PostgreSQL database
        conn = psycopg2.connect("dbname='ESLAB' user='pi' host='192.168.43.168' password='448346'")
        # create a new cursor
        cur = conn.cursor()
        # execute the INSERT statement
        cur.execute(query, (student_id, name, phoneNumber, advisorID, departmentID))
        # get the id back
        studentID = cur.fetchone()[0]
        # commit the changes to the database
        conn.commit()
        # close communication with the database
        cur.close()
    except (Exception, psycopg2.DatabaseError) as error:
        print(error)
    finally:
        if conn is not None:
            conn.close()

    return studentID

if __name__ == '__main__':
    insertValue(8,"Botak","01128877024", 4, 8)


