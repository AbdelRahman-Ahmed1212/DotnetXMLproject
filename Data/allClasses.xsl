<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
	xmlns:array="http://www.w3.org/2005/xpath-functions/array"
	xmlns:map="http://www.w3.org/2005/xpath-functions/map"
	xmlns:math="http://www.w3.org/2005/xpath-functions/math"
	exclude-result-prefixes="#all"
	expand-text="yes"
	version="3.0">
	
	<xsl:output method="xml" indent="yes"/>
	<xsl:mode on-no-match="shallow-copy"/>
    <xsl:variable name="Fdate" select="'2024-02-16'"/>
	<xsl:template match="/" name="notFinal">
		<output>
			<xsl:for-each select="attendanceRecords/attendanceRecord">
					<xsl:variable name="outerId" select="stdId"/>
				<record>
					<id>
						<xsl:value-of select="id"/>
					</id>
					<studentID>
						<xsl:value-of select="stdId"/>
					</studentID>
					<xsl:for-each select="../attendanceRecord">
						<xsl:choose>
							<xsl:when test="stdId = $outerId  and date > $Fdate">
								<status> <xsl:value-of select="status"/></status>
							</xsl:when>
						</xsl:choose>
					</xsl:for-each>

				</record>
				
			</xsl:for-each> 
		</output>
	</xsl:template>
	
	
</xsl:stylesheet>