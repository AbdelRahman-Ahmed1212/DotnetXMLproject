<!-- XSLT Stylesheet -->
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">

	<!-- Identity template - copy everything as is -->
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>

	<!-- Template to match attendanceRecords and process each student -->
	<xsl:template match="attendanceRecords">
		<table border="1">
			<!-- Group attendanceRecord elements by stdId -->
			<for-each-group select="attendanceRecord" group-by="stdId">
				<tr>
					<!-- Add a cell for each date, status, and classId -->
					<th>Student ID</th>
					<th>Date</th>
					<th>Status</th>
					<th>Class ID</th>
				</tr>
				<for-each select="current-group()">
					<tr>
						<td>
							<xsl:value-of select="stdId"/>
						</td>
						<td>
							<xsl:value-of select="date"/>
						</td>
						<td>
							<xsl:value-of select="status"/>
						</td>
						<td>
							<xsl:value-of select="classId"/>
						</td>
					</tr>
				</for-each>
			</for-each-group>
		</table>
	</xsl:template>

</xsl:stylesheet>
