import psycopg2

def updateStudentName(studentID, studentName):
    """ update student name base on the student id """
    query = ''' UPDATE public."Student" SET "Name" = %s WHERE "ID" = %s'''
    updated_rows = 0

    try:
        conn = psycopg2.connect("dbname='ESLAB' user='pi' host='192.168.43.168' password='448346'")
        cur = conn.cursor()
        cur.execute(query, (studentName, studentID))
        updated_rows = cur.rowcount
        conn.commit()
        cur.close()
    except (Exception, psycopg2.DatabaseError) as error:
        print(error)
    finally:
        if conn is not None:
            conn.close()

    return updated_rows

if __name__ == '__main__':
    updateStudentName(8, "Hazim")




