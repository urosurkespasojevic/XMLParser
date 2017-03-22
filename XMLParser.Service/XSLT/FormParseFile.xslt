<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  <xsl:output method="html" indent="yes"/>

  <xsl:template match="/form">
    

        <form name="{id}" action="http://localhost:62532/Parser.svc/submitform/{id}" method="POST">
          <!-- parsing textboxes -->
          <xsl:for-each select="./textbox">
            <xsl:if test="./id = 'password'">
              <label>
                <xsl:value-of select="./description"/>
              </label>
              <input type="password" name ="{./id}" />
            </xsl:if>

            <xsl:if test="./id != 'password'">
              <label>
                <xsl:value-of select="./description"/>
              </label>
              <input type="text" name ="{./id}"/>
            </xsl:if>

          </xsl:for-each>

          <!-- parsing buttons -->

          <xsl:for-each select="./button">
            <xsl:if test="./id = 'submit'">
              <input type="submit" value="{./description}"/>
              <!--<xsl:value-of select=""/>
              </button>-->
            </xsl:if>
          </xsl:for-each>
        </form>
        <script src="Scripts/app/app.js"></script>
     
  </xsl:template>
</xsl:stylesheet>
