Feature: ProfilePageFeature

As I need to sell my skills, I have to create, update and delete my skills in the 
profile page, so that others can view it.

@tag1
Scenario: I logged to the project Mars portal with valid credentials and check the profile name
	Given I logged into the web portal successfully with valid credentials
	And I navigated to the profile home page
	When I clicked on the profile home page 
	Then I could see the profile name displayed

Scenario Outline: Creating language to the profile
    Given I logged into the web portal successfully to create the language
	And I navigated to the profile page to create language
	When I created '<language>' on the profile page
	Then The language record should be able to create '<language>'
	Examples: 
	| language |
	| English  |

Scenario Outline: Updating language to the profile
    Given I logged into the web portal successfully to update the language
	And I navigated to the profile page to update language
	When I update '<Updatelanguage>' on the profile page
	Then The language record should be able to update the '<Updatelanguage>'
	Examples: 
	| Updatelanguage |
	| Malayalam      |

Scenario: Deleting the language on the profile
    Given I logged into the web portal successfully to delete the language
	And I navigated to the profile page to delete language
	When I delete the language on the profile page
	Then The language record should get deleted

Scenario Outline: Creating Skill to my profile
    Given I Logged into the web portal successfully to add the skill
	And I navigated to the profile page to add skill
	When I created skill '<Skill>' on the profile page
	Then I should be able to create '<Skill>' 
	Examples: 
	| Skill |
	| C#    |

Scenario Outline: Updating Skill on the profile
    Given I logged into the web portal successfully to update my skill
	And I navigated to the profile page to update my skill
	When I updated the '<Updateskill>' on the profile page
	Then I should be able to Update '<Updateskill>'
	Examples: 
	| Updateskill |
	| C++         |

Scenario: Deleting the skill on the profile
    Given I logged into the web portal successfully to delete my skill
	And I navigated to the profile page to delete my skill
	When I deleted the skill on the profile page
	Then The skill record should be deleted

Scenario Outline: Creating education to the profile
    Given I logged into the web portal successfully to create education
	And I navigated to the profile page to create education
	When I create education '<college>','<degree>'on the profile page
	Then The education record should be able to create '<college>','<degree>'
	Examples: 
	| college     | degree |
	| PSG College | ECE    |

Scenario Outline: Updating education to the profile
	Given I logged into the web portal successfully to update the education
	And I navigated to the profile page to update education
	When I update the education '<Updatecollege>','<Updatedegree'> on the profile page
	Then The education record should be able to update '<Updatecollege>','<Updatedegree'>
	Examples: 
	| Updatecollege | Updatedegree |
	| AJK           | EEE          |

Scenario: Deleting the education on the profile
	Given I logged into the web portal successfully to delete the education
	And I navigated to the profile page to delete education
	When I delete the education on the profile page
	Then The education record should get deleted

Scenario Outline: Creating certification on the profile 
	Given I logged into the web portal successfully to create certification
	And I navigated to the profile page to create certification
	When I created certification '<certificate>','<certifiedfrom>' on the profile page
	Then The certification record should be able to create '<certificate>','<certifiedfrom>'
	Examples: 
	| certificate                | certifiedfrom |
	| IndustryConnectCertificate | MVP Studio    |

	Scenario Outline: Updating certificate to the profile
	Given I logged into the web portal successfully to update the certificate
	And I navigated to the profile page to update certification
	When I updated the certification '<Updatecertificate>','<Updatecertifiedfrom>' on the profile page
	Then The certification record should be able to update '<Updatecertificate>','<Updatecertifiedfrom>'
	Examples: 
	| Updatecertificate | Updatecertifiedfrom |
	| ICCertificate     | MVP                 |

	Scenario: Deleting the certification on the profile
	Given I logged into the web portal successfully to delete the certification
	And I navigated to the profile page to delete certification
	When I delete the certification on the profile page
	Then The certification record should get deleted




